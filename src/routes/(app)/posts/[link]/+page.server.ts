import { posts } from '../data.js';
import {escapeSvelte, mdsvex, compile} from 'mdsvex'
import {error, Load} from "@sveltejs/kit";
import {createHighlighter} from "shiki";

export const load: Load = async ({ params }) => {
    const post = posts.find(post => post.link === params.link);
    if (!post) throw error(404);

    const mdsvexOptions = {
        extensions: ['.md'],
        highlight: {
            highlighter: async (code, lang = 'text') => {
                const highlighter = await createHighlighter({
                    themes: ['github-dark'],
                    langs: ['javascript', 'typescript','bash'],
                })
                await highlighter.loadLanguage('javascript', 'typescript', 'bash')
                const html = escapeSvelte(highlighter.codeToHtml(code, { lang, theme: 'github-dark' }))
                return `${html}`
            }

        },

    }
    const compiledResponse = await compile(post.content, mdsvexOptions);

    return {
        content: compiledResponse?.code
    };
};