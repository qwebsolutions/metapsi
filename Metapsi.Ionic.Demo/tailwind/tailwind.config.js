/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["../*.cs"],
  safelist: [
    {
      pattern: /bg-(gray|neutral|red|green|blue|orange|yellow|scc-cyan)-(100|200|300|400|500|600|700|800|900)/,
    },
	{
      pattern: /text-(gray|neutral|red|green|blue|orange|yellow|scc-cyan)-(100|200|300|400|500|600|700|800|900)/, 
    }
	]
}
