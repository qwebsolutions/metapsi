/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["../*.cs", "../features/*.cs", "../docs/articles/*.md", "../docs/samples/*.cs"],
  plugins: [
    require('@tailwindcss/typography')
  ],  
  safelist: [
    {
      pattern: /bg-(gray|neutral|red|green|blue|orange|yellow|scc-cyan)-(100|200|300|400|500|600|700|800|900)/,
    },
	{
      pattern: /text-(gray|neutral|red|green|blue|orange|yellow|scc-cyan)-(100|200|300|400|500|600|700|800|900)/, 
    },
	{
      pattern: /border-(gray|neutral|red|green|blue|orange|yellow|scc-cyan)-(100|200|300|400|500|600|700|800|900)/, 
    },
	{
      pattern: /p-(1|2|3|4|6|8)/, 
    },
	{
      pattern: /border/, 
    }
	]
}
