const mix = require('laravel-mix');

/*
 |--------------------------------------------------------------------------
 | Mix Asset Management
 |--------------------------------------------------------------------------
 |
 | Mix provides a clean, fluent API for defining some Webpack build steps
 | for your Laravel application. By default, we are compiling the Sass
 | file for the application as well as bundling up all the JS files.
 |
 */

mix.js('resources/portfolio/js/app.js', 'public/portfolio/js/all.js')
    .sass('resources/portfolio/scss/app.scss', 'public/portfolio/css/all.css');
