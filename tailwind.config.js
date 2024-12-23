import flowbitePlugin from 'flowbite/plugin'
/** @type {import('tailwindcss').Config} */
export default {
  content: ["./src/**/*.{html,js,svelte,ts}",  './node_modules/flowbite-svelte/**/*.{html,js,svelte,ts}'],

  theme: {
    extend: {
      colors:{
        'prime': '424245',
        'second': '#1D1D1F',
      }
    }
  },

  plugins: [flowbitePlugin]
};
