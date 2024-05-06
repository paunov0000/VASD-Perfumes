/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./wwwroot/pages/*.html", "./Views/**/*.cshtml", "./Areas/**/*.cshtml"],
    theme: {
        extend: {
            fontFamily: {
                main: ["Montserrat", "sans-serif"],
            },
            width: {
                "site-width": "1500px",
            },
            keyframes: {
                animatedgradient: {
                    '0%': { backgroundPosition: '0% 50%' },
                    '50%': { backgroundPosition: '100% 50%' },
                    '100%': { backgroundPosition: '0% 50%' },
                },
            },
            backgroundSize: {
                '200%': '200%'
            },
            animation: {
                gradient: 'animatedgradient 6s ease infinite alternate'
            }
        },
    },
    plugins: [],
};
