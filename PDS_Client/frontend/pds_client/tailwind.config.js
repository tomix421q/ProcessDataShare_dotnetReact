/** @type {import('tailwindcss').Config} */
export default {
  content: ['./index.html', './src/**/*.{js,ts,jsx,tsx}'],
  theme: {
    fontFamily: {
      primary: 'Fira Sans',
      secondary: 'Rajdhani',
      extraFont: 'Roboto',
    },
    container: {
      padding: {
        DEFAULT: '15px',
      },
    },
    screens: {
      sm: '640px',
      md: '768px',
      lg: '960px',
      xl: '2200px',
    },
    extend: {
      colors: {
        primary: '#f4eeff',
        secondary: '#8dc6ff',
        collor1: '#686ee2',
        collor2: '#e94822',
      },
      backgroundImage: {},
    },
  },
  plugins: [],
}
