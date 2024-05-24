/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["./wwwroot/pages/*.html", "./Views/**/*.cshtml", "./Areas/**/*.cshtml"],
    theme: {
        extend: {
            fontFamily: {
                main: ["Montserrat", "sans-serif"],
            },
            fontSize: {
                footerSub: '1.17rem'
            },
            width: {
                "main-width": "1035px",
            },
            keyframes: {
                animatedgradient: {
                    '0%': { backgroundPosition: '0% 50%' },
                    '50%': { backgroundPosition: '100% 50%' },
                    '100%': { backgroundPosition: '0% 50%' },
                },
                animatedhover: {
                    '0%': { bottom: '0' },
                    '50%': { bottom: '0.75rem' },
                    '100%': { bottom: '0' }
                }
            },
            backgroundSize: {
                '200%': '200%'
            },
            animation: {
                gradient: 'animatedgradient 6s ease infinite alternate',
                hover: 'animatedhover 1.25s ease-in-out infinite'
            }
        },
    },
    plugins: [],
};
