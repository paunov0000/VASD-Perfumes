/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./wwwroot/pages/*.html", "./Views/**/*.cshtml"],
  theme: {
    extend: {
      fontFamily: {
        main: ["Montserrat", "sans-serif"],
      },
      width: {
        "site-width": "1500px",
      },
    },
  },
  plugins: [],
};
