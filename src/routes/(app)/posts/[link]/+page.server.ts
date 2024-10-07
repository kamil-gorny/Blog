import { posts } from '../data.js';
import { compile } from "mdsvex";
import {error, Load} from "@sveltejs/kit";

export const load: Load = async ({ params }) => {
    const post = posts.find(post => post.link === params.link);
    if (!post) throw error(404);
    const compiledResponse = await compile(post.content);

    return {
        content: compiledResponse?.code.replace(/>{@html `<code class="language-/g, '><code class="language-')
            .replace(/<\/code>`}<\/pre>/g, '</code></pre>')
    };
};