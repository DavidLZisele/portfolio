@import url(https://fonts.googleapis.com/css?family=Nunito);@charset "UTF-8";

/*!
 * Bootstrap v4.5.3 (https://getbootstrap.com/)
 * Copyright 2011-2020 The Bootstrap Authors
 * Copyright 2011-2020 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/main/LICENSE)
 */

:root {
  --blue: #3490dc;
  --indigo: #6574cd;
  --purple: #9561e2;
  --pink: #f66d9b;
  --red: #e3342f;
  --orange: #f6993f;
  --yellow: #ffed4a;
  --green: #38c172;
  --teal: #4dc0b5;
  --cyan: #6cb2eb;
  --white: #fff;
  --gray: #6c757d;
  --gray-dark: #343a40;
  --primary: #3490dc;
  --secondary: #6c757d;
  --success: #38c172;
  --info: #6cb2eb;
  --warning: #ffed4a;
  --danger: #e3342f;
  --light: #f8f9fa;
  --dark: #343a40;
  --breakpoint-xs: 0;
  --breakpoint-sm: 576px;
  --breakpoint-md: 768px;
  --breakpoint-lg: 992px;
  --breakpoint-xl: 1200px;
  --font-family-sans-serif: "Nunito", sans-serif;
  --font-family-monospace: SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
}

*,
*::before,
*::after {
  box-sizing: border-box;
}

html {
  font-family: sans-serif;
  line-height: 1.15;
  -webkit-text-size-adjust: 100%;
  -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
}

article,
aside,
figcaption,
figure,
footer,
header,
hgroup,
main,
nav,
section {
  display: block;
}

body {
  margin: 0;
  font-family: "Nunito", sans-serif;
  font-size: 0.9rem;
  font-weight: 400;
  line-height: 1.6;
  color: #212529;
  text-align: left;
  background-color: #f8fafc;
}

[tabindex="-1"]:focus:not(:focus-visible) {
  outline: 0 !important;
}

hr {
  box-sizing: content-box;
  height: 0;
  overflow: visible;
}

h1,
h2,
h3,
h4,
h5,
h6 {
  margin-top: 0;
  margin-bottom: 0.5rem;
}

p {
  margin-top: 0;
  margin-bottom: 1rem;
}

abbr[title],
abbr[data-original-title] {
  text-decoration: underline;
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
  cursor: help;
  border-bottom: 0;
  -webkit-text-decoration-skip-ink: none;
          text-decoration-skip-ink: none;
}

address {
  margin-bottom: 1rem;
  font-style: normal;
  line-height: inherit;
}

ol,
ul,
dl {
  margin-top: 0;
  margin-bottom: 1rem;
}

ol ol,
ul ul,
ol ul,
ul ol {
  margin-bottom: 0;
}

dt {
  font-weight: 700;
}

dd {
  margin-bottom: 0.5rem;
  margin-left: 0;
}

blockquote {
  margin: 0 0 1rem;
}

b,
strong {
  font-weight: bolder;
}

small {
  font-size: 80%;
}

sub,
sup {
  position: relative;
  font-size: 75%;
  line-height: 0;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

a {
  color: #3490dc;
  text-decoration: none;
  background-color: transparent;
}

a:hover {
  color: #1d68a7;
  text-decoration: underline;
}

a:not([href]):not([class]) {
  color: inherit;
  text-decoration: none;
}

a:not([href]):not([class]):hover {
  color: inherit;
  text-decoration: none;
}

pre,
code,
kbd,
samp {
  font-family: SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  font-size: 1em;
}

pre {
  margin-top: 0;
  margin-bottom: 1rem;
  overflow: auto;
  -ms-overflow-style: scrollbar;
}

figure {
  margin: 0 0 1rem;
}

img {
  vertical-align: middle;
  border-style: none;
}

svg {
  overflow: hidden;
  vertical-align: middle;
}

table {
  border-collapse: collapse;
}

caption {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
  color: #6c757d;
  text-align: left;
  caption-side: bottom;
}

th {
  text-align: inherit;
  text-align: -webkit-match-parent;
}

label {
  display: inline-block;
  margin-bottom: 0.5rem;
}

button {
  border-radius: 0;
}

button:focus {
  outline: 1px dotted;
  outline: 5px auto -webkit-focus-ring-color;
}

input,
button,
select,
optgroup,
textarea {
  margin: 0;
  font-family: inherit;
  font-size: inherit;
  line-height: inherit;
}

button,
input {
  overflow: visible;
}

button,
select {
  text-transform: none;
}

[role=button] {
  cursor: pointer;
}

select {
  word-wrap: normal;
}

button,
[type=button],
[type=reset],
[type=submit] {
  -webkit-appearance: button;
}

button:not(:disabled),
[type=button]:not(:disabled),
[type=reset]:not(:disabled),
[type=submit]:not(:disabled) {
  cursor: pointer;
}

button::-moz-focus-inner,
[type=button]::-moz-focus-inner,
[type=reset]::-moz-focus-inner,
[type=submit]::-moz-focus-inner {
  padding: 0;
  border-style: none;
}

input[type=radio],
input[type=checkbox] {
  box-sizing: border-box;
  padding: 0;
}

textarea {
  overflow: auto;
  resize: vertical;
}

fieldset {
  min-width: 0;
  padding: 0;
  margin: 0;
  border: 0;
}

legend {
  display: block;
  width: 100%;
  max-width: 100%;
  padding: 0;
  margin-bottom: 0.5rem;
  font-size: 1.5rem;
  line-height: inherit;
  color: inherit;
  white-space: normal;
}

progress {
  vertical-align: baseline;
}

[type=number]::-webkit-inner-spin-button,
[type=number]::-webkit-outer-spin-button {
  height: auto;
}

[type=search] {
  outline-offset: -2px;
  -webkit-appearance: none;
}

[type=search]::-webkit-search-decoration {
  -webkit-appearance: none;
}

::-webkit-file-upload-button {
  font: inherit;
  -webkit-appearance: button;
}

output {
  display: inline-block;
}

summary {
  display: list-item;
  cursor: pointer;
}

template {
  display: none;
}

[hidden] {
  display: none !important;
}

h1,
h2,
h3,
h4,
h5,
h6,
.h1,
.h2,
.h3,
.h4,
.h5,
.h6 {
  margin-bottom: 0.5rem;
  font-weight: 500;
  line-height: 1.2;
}

h1,
.h1 {
  font-size: 2.25rem;
}

h2,
.h2 {
  font-size: 1.8rem;
}

h3,
.h3 {
  font-size: 1.575rem;
}

h4,
.h4 {
  font-size: 1.35rem;
}

h5,
.h5 {
  font-size: 1.125rem;
}

h6,
.h6 {
  font-size: 0.9rem;
}

.lead {
  font-size: 1.125rem;
  font-weight: 300;
}

.display-1 {
  font-size: 6rem;
  font-weight: 300;
  line-height: 1.2;
}

.display-2 {
  font-size: 5.5rem;
  font-weight: 300;
  line-height: 1.2;
}

.display-3 {
  font-size: 4.5rem;
  font-weight: 300;
  line-height: 1.2;
}

.display-4 {
  font-size: 3.5rem;
  font-weight: 300;
  line-height: 1.2;
}

hr {
  margin-top: 1rem;
  margin-bottom: 1rem;
  border: 0;
  border-top: 1px solid rgba(0, 0, 0, 0.1);
}

small,
.small {
  font-size: 80%;
  font-weight: 400;
}

mark,
.mark {
  padding: 0.2em;
  background-color: #fcf8e3;
}

.list-unstyled {
  padding-left: 0;
  list-style: none;
}

.list-inline {
  padding-left: 0;
  list-style: none;
}

.list-inline-item {
  display: inline-block;
}

.list-inline-item:not(:last-child) {
  margin-right: 0.5rem;
}

.initialism {
  font-size: 90%;
  text-transform: uppercase;
}

.blockquote {
  margin-bottom: 1rem;
  font-size: 1.125rem;
}

.blockquote-footer {
  display: block;
  font-size: 80%;
  color: #6c757d;
}

.blockquote-footer::before {
  content: "\2014\A0";
}

.img-fluid {
  max-width: 100%;
  height: auto;
}

.img-thumbnail {
  padding: 0.25rem;
  background-color: #f8fafc;
  border: 1px solid #dee2e6;
  border-radius: 0.25rem;
  max-width: 100%;
  height: auto;
}

.figure {
  display: inline-block;
}

.figure-img {
  margin-bottom: 0.5rem;
  line-height: 1;
}

.figure-caption {
  font-size: 90%;
  color: #6c757d;
}

code {
  font-size: 87.5%;
  color: #f66d9b;
  word-wrap: break-word;
}

a > code {
  color: inherit;
}

kbd {
  padding: 0.2rem 0.4rem;
  font-size: 87.5%;
  color: #fff;
  background-color: #212529;
  border-radius: 0.2rem;
}

kbd kbd {
  padding: 0;
  font-size: 100%;
  font-weight: 700;
}

pre {
  display: block;
  font-size: 87.5%;
  color: #212529;
}

pre code {
  font-size: inherit;
  color: inherit;
  word-break: normal;
}

.pre-scrollable {
  max-height: 340px;
  overflow-y: scroll;
}

.container,
.container-fluid,
.container-xl,
.container-lg,
.container-md,
.container-sm {
  width: 100%;
  padding-right: 15px;
  padding-left: 15px;
  margin-right: auto;
  margin-left: auto;
}

@media (min-width: 576px) {
  .container-sm,
  .container {
    max-width: 540px;
  }
}

@media (min-width: 768px) {
  .container-md,
  .container-sm,
  .container {
    max-width: 720px;
  }
}

@media (min-width: 992px) {
  .container-lg,
  .container-md,
  .container-sm,
  .container {
    max-width: 960px;
  }
}

@media (min-width: 1200px) {
  .container-xl,
  .container-lg,
  .container-md,
  .container-sm,
  .container {
    max-width: 1140px;
  }
}

.row {
  display: flex;
  flex-wrap: wrap;
  margin-right: -15px;
  margin-left: -15px;
}

.no-gutters {
  margin-right: 0;
  margin-left: 0;
}

.no-gutters > .col,
.no-gutters > [class*=col-] {
  padding-right: 0;
  padding-left: 0;
}

.col-xl,
.col-xl-auto,
.col-xl-12,
.col-xl-11,
.col-xl-10,
.col-xl-9,
.col-xl-8,
.col-xl-7,
.col-xl-6,
.col-xl-5,
.col-xl-4,
.col-xl-3,
.col-xl-2,
.col-xl-1,
.col-lg,
.col-lg-auto,
.col-lg-12,
.col-lg-11,
.col-lg-10,
.col-lg-9,
.col-lg-8,
.col-lg-7,
.col-lg-6,
.col-lg-5,
.col-lg-4,
.col-lg-3,
.col-lg-2,
.col-lg-1,
.col-md,
.col-md-auto,
.col-md-12,
.col-md-11,
.col-md-10,
.col-md-9,
.col-md-8,
.col-md-7,
.col-md-6,
.col-md-5,
.col-md-4,
.col-md-3,
.col-md-2,
.col-md-1,
.col-sm,
.col-sm-auto,
.col-sm-12,
.col-sm-11,
.col-sm-10,
.col-sm-9,
.col-sm-8,
.col-sm-7,
.col-sm-6,
.col-sm-5,
.col-sm-4,
.col-sm-3,
.col-sm-2,
.col-sm-1,
.col,
.col-auto,
.col-12,
.col-11,
.col-10,
.col-9,
.col-8,
.col-7,
.col-6,
.col-5,
.col-4,
.col-3,
.col-2,
.col-1 {
  position: relative;
  width: 100%;
  padding-right: 15px;
  padding-left: 15px;
}

.col {
  flex-basis: 0;
  flex-grow: 1;
  max-width: 100%;
}

.row-cols-1 > * {
  flex: 0 0 100%;
  max-width: 100%;
}

.row-cols-2 > * {
  flex: 0 0 50%;
  max-width: 50%;
}

.row-cols-3 > * {
  flex: 0 0 33.3333333333%;
  max-width: 33.3333333333%;
}

.row-cols-4 > * {
  flex: 0 0 25%;
  max-width: 25%;
}

.row-cols-5 > * {
  flex: 0 0 20%;
  max-width: 20%;
}

.row-cols-6 > * {
  flex: 0 0 16.6666666667%;
  max-width: 16.6666666667%;
}

.col-auto {
  flex: 0 0 auto;
  width: auto;
  max-width: 100%;
}

.col-1 {
  flex: 0 0 8.3333333333%;
  max-width: 8.3333333333%;
}

.col-2 {
  flex: 0 0 16.6666666667%;
  max-width: 16.6666666667%;
}

.col-3 {
  flex: 0 0 25%;
  max-width: 25%;
}

.col-4 {
  flex: 0 0 33.3333333333%;
  max-width: 33.3333333333%;
}

.col-5 {
  flex: 0 0 41.6666666667%;
  max-width: 41.6666666667%;
}

.col-6 {
  flex: 0 0 50%;
  max-width: 50%;
}

.col-7 {
  flex: 0 0 58.3333333333%;
  max-width: 58.3333333333%;
}

.col-8 {
  flex: 0 0 66.6666666667%;
  max-width: 66.6666666667%;
}

.col-9 {
  flex: 0 0 75%;
  max-width: 75%;
}

.col-10 {
  flex: 0 0 83.3333333333%;
  max-width: 83.3333333333%;
}

.col-11 {
  flex: 0 0 91.6666666667%;
  max-width: 91.6666666667%;
}

.col-12 {
  flex: 0 0 100%;
  max-width: 100%;
}

.order-first {
  order: -1;
}

.order-last {
  order: 13;
}

.order-0 {
  order: 0;
}

.order-1 {
  order: 1;
}

.order-2 {
  order: 2;
}

.order-3 {
  order: 3;
}

.order-4 {
  order: 4;
}

.order-5 {
  order: 5;
}

.order-6 {
  order: 6;
}

.order-7 {
  order: 7;
}

.order-8 {
  order: 8;
}

.order-9 {
  order: 9;
}

.order-10 {
  order: 10;
}

.order-11 {
  order: 11;
}

.order-12 {
  order: 12;
}

.offset-1 {
  margin-left: 8.3333333333%;
}

.offset-2 {
  margin-left: 16.6666666667%;
}

.offset-3 {
  margin-left: 25%;
}

.offset-4 {
  margin-left: 33.3333333333%;
}

.offset-5 {
  margin-left: 41.6666666667%;
}

.offset-6 {
  margin-left: 50%;
}

.offset-7 {
  margin-left: 58.3333333333%;
}

.offset-8 {
  margin-left: 66.6666666667%;
}

.offset-9 {
  margin-left: 75%;
}

.offset-10 {
  margin-left: 83.3333333333%;
}

.offset-11 {
  margin-left: 91.6666666667%;
}

@media (min-width: 576px) {
  .col-sm {
    flex-basis: 0;
    flex-grow: 1;
    max-width: 100%;
  }

  .row-cols-sm-1 > * {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .row-cols-sm-2 > * {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .row-cols-sm-3 > * {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .row-cols-sm-4 > * {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .row-cols-sm-5 > * {
    flex: 0 0 20%;
    max-width: 20%;
  }

  .row-cols-sm-6 > * {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-sm-auto {
    flex: 0 0 auto;
    width: auto;
    max-width: 100%;
  }

  .col-sm-1 {
    flex: 0 0 8.3333333333%;
    max-width: 8.3333333333%;
  }

  .col-sm-2 {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-sm-3 {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .col-sm-4 {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .col-sm-5 {
    flex: 0 0 41.6666666667%;
    max-width: 41.6666666667%;
  }

  .col-sm-6 {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .col-sm-7 {
    flex: 0 0 58.3333333333%;
    max-width: 58.3333333333%;
  }

  .col-sm-8 {
    flex: 0 0 66.6666666667%;
    max-width: 66.6666666667%;
  }

  .col-sm-9 {
    flex: 0 0 75%;
    max-width: 75%;
  }

  .col-sm-10 {
    flex: 0 0 83.3333333333%;
    max-width: 83.3333333333%;
  }

  .col-sm-11 {
    flex: 0 0 91.6666666667%;
    max-width: 91.6666666667%;
  }

  .col-sm-12 {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .order-sm-first {
    order: -1;
  }

  .order-sm-last {
    order: 13;
  }

  .order-sm-0 {
    order: 0;
  }

  .order-sm-1 {
    order: 1;
  }

  .order-sm-2 {
    order: 2;
  }

  .order-sm-3 {
    order: 3;
  }

  .order-sm-4 {
    order: 4;
  }

  .order-sm-5 {
    order: 5;
  }

  .order-sm-6 {
    order: 6;
  }

  .order-sm-7 {
    order: 7;
  }

  .order-sm-8 {
    order: 8;
  }

  .order-sm-9 {
    order: 9;
  }

  .order-sm-10 {
    order: 10;
  }

  .order-sm-11 {
    order: 11;
  }

  .order-sm-12 {
    order: 12;
  }

  .offset-sm-0 {
    margin-left: 0;
  }

  .offset-sm-1 {
    margin-left: 8.3333333333%;
  }

  .offset-sm-2 {
    margin-left: 16.6666666667%;
  }

  .offset-sm-3 {
    margin-left: 25%;
  }

  .offset-sm-4 {
    margin-left: 33.3333333333%;
  }

  .offset-sm-5 {
    margin-left: 41.6666666667%;
  }

  .offset-sm-6 {
    margin-left: 50%;
  }

  .offset-sm-7 {
    margin-left: 58.3333333333%;
  }

  .offset-sm-8 {
    margin-left: 66.6666666667%;
  }

  .offset-sm-9 {
    margin-left: 75%;
  }

  .offset-sm-10 {
    margin-left: 83.3333333333%;
  }

  .offset-sm-11 {
    margin-left: 91.6666666667%;
  }
}

@media (min-width: 768px) {
  .col-md {
    flex-basis: 0;
    flex-grow: 1;
    max-width: 100%;
  }

  .row-cols-md-1 > * {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .row-cols-md-2 > * {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .row-cols-md-3 > * {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .row-cols-md-4 > * {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .row-cols-md-5 > * {
    flex: 0 0 20%;
    max-width: 20%;
  }

  .row-cols-md-6 > * {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-md-auto {
    flex: 0 0 auto;
    width: auto;
    max-width: 100%;
  }

  .col-md-1 {
    flex: 0 0 8.3333333333%;
    max-width: 8.3333333333%;
  }

  .col-md-2 {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-md-3 {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .col-md-4 {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .col-md-5 {
    flex: 0 0 41.6666666667%;
    max-width: 41.6666666667%;
  }

  .col-md-6 {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .col-md-7 {
    flex: 0 0 58.3333333333%;
    max-width: 58.3333333333%;
  }

  .col-md-8 {
    flex: 0 0 66.6666666667%;
    max-width: 66.6666666667%;
  }

  .col-md-9 {
    flex: 0 0 75%;
    max-width: 75%;
  }

  .col-md-10 {
    flex: 0 0 83.3333333333%;
    max-width: 83.3333333333%;
  }

  .col-md-11 {
    flex: 0 0 91.6666666667%;
    max-width: 91.6666666667%;
  }

  .col-md-12 {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .order-md-first {
    order: -1;
  }

  .order-md-last {
    order: 13;
  }

  .order-md-0 {
    order: 0;
  }

  .order-md-1 {
    order: 1;
  }

  .order-md-2 {
    order: 2;
  }

  .order-md-3 {
    order: 3;
  }

  .order-md-4 {
    order: 4;
  }

  .order-md-5 {
    order: 5;
  }

  .order-md-6 {
    order: 6;
  }

  .order-md-7 {
    order: 7;
  }

  .order-md-8 {
    order: 8;
  }

  .order-md-9 {
    order: 9;
  }

  .order-md-10 {
    order: 10;
  }

  .order-md-11 {
    order: 11;
  }

  .order-md-12 {
    order: 12;
  }

  .offset-md-0 {
    margin-left: 0;
  }

  .offset-md-1 {
    margin-left: 8.3333333333%;
  }

  .offset-md-2 {
    margin-left: 16.6666666667%;
  }

  .offset-md-3 {
    margin-left: 25%;
  }

  .offset-md-4 {
    margin-left: 33.3333333333%;
  }

  .offset-md-5 {
    margin-left: 41.6666666667%;
  }

  .offset-md-6 {
    margin-left: 50%;
  }

  .offset-md-7 {
    margin-left: 58.3333333333%;
  }

  .offset-md-8 {
    margin-left: 66.6666666667%;
  }

  .offset-md-9 {
    margin-left: 75%;
  }

  .offset-md-10 {
    margin-left: 83.3333333333%;
  }

  .offset-md-11 {
    margin-left: 91.6666666667%;
  }
}

@media (min-width: 992px) {
  .col-lg {
    flex-basis: 0;
    flex-grow: 1;
    max-width: 100%;
  }

  .row-cols-lg-1 > * {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .row-cols-lg-2 > * {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .row-cols-lg-3 > * {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .row-cols-lg-4 > * {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .row-cols-lg-5 > * {
    flex: 0 0 20%;
    max-width: 20%;
  }

  .row-cols-lg-6 > * {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-lg-auto {
    flex: 0 0 auto;
    width: auto;
    max-width: 100%;
  }

  .col-lg-1 {
    flex: 0 0 8.3333333333%;
    max-width: 8.3333333333%;
  }

  .col-lg-2 {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-lg-3 {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .col-lg-4 {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .col-lg-5 {
    flex: 0 0 41.6666666667%;
    max-width: 41.6666666667%;
  }

  .col-lg-6 {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .col-lg-7 {
    flex: 0 0 58.3333333333%;
    max-width: 58.3333333333%;
  }

  .col-lg-8 {
    flex: 0 0 66.6666666667%;
    max-width: 66.6666666667%;
  }

  .col-lg-9 {
    flex: 0 0 75%;
    max-width: 75%;
  }

  .col-lg-10 {
    flex: 0 0 83.3333333333%;
    max-width: 83.3333333333%;
  }

  .col-lg-11 {
    flex: 0 0 91.6666666667%;
    max-width: 91.6666666667%;
  }

  .col-lg-12 {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .order-lg-first {
    order: -1;
  }

  .order-lg-last {
    order: 13;
  }

  .order-lg-0 {
    order: 0;
  }

  .order-lg-1 {
    order: 1;
  }

  .order-lg-2 {
    order: 2;
  }

  .order-lg-3 {
    order: 3;
  }

  .order-lg-4 {
    order: 4;
  }

  .order-lg-5 {
    order: 5;
  }

  .order-lg-6 {
    order: 6;
  }

  .order-lg-7 {
    order: 7;
  }

  .order-lg-8 {
    order: 8;
  }

  .order-lg-9 {
    order: 9;
  }

  .order-lg-10 {
    order: 10;
  }

  .order-lg-11 {
    order: 11;
  }

  .order-lg-12 {
    order: 12;
  }

  .offset-lg-0 {
    margin-left: 0;
  }

  .offset-lg-1 {
    margin-left: 8.3333333333%;
  }

  .offset-lg-2 {
    margin-left: 16.6666666667%;
  }

  .offset-lg-3 {
    margin-left: 25%;
  }

  .offset-lg-4 {
    margin-left: 33.3333333333%;
  }

  .offset-lg-5 {
    margin-left: 41.6666666667%;
  }

  .offset-lg-6 {
    margin-left: 50%;
  }

  .offset-lg-7 {
    margin-left: 58.3333333333%;
  }

  .offset-lg-8 {
    margin-left: 66.6666666667%;
  }

  .offset-lg-9 {
    margin-left: 75%;
  }

  .offset-lg-10 {
    margin-left: 83.3333333333%;
  }

  .offset-lg-11 {
    margin-left: 91.6666666667%;
  }
}

@media (min-width: 1200px) {
  .col-xl {
    flex-basis: 0;
    flex-grow: 1;
    max-width: 100%;
  }

  .row-cols-xl-1 > * {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .row-cols-xl-2 > * {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .row-cols-xl-3 > * {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .row-cols-xl-4 > * {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .row-cols-xl-5 > * {
    flex: 0 0 20%;
    max-width: 20%;
  }

  .row-cols-xl-6 > * {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-xl-auto {
    flex: 0 0 auto;
    width: auto;
    max-width: 100%;
  }

  .col-xl-1 {
    flex: 0 0 8.3333333333%;
    max-width: 8.3333333333%;
  }

  .col-xl-2 {
    flex: 0 0 16.6666666667%;
    max-width: 16.6666666667%;
  }

  .col-xl-3 {
    flex: 0 0 25%;
    max-width: 25%;
  }

  .col-xl-4 {
    flex: 0 0 33.3333333333%;
    max-width: 33.3333333333%;
  }

  .col-xl-5 {
    flex: 0 0 41.6666666667%;
    max-width: 41.6666666667%;
  }

  .col-xl-6 {
    flex: 0 0 50%;
    max-width: 50%;
  }

  .col-xl-7 {
    flex: 0 0 58.3333333333%;
    max-width: 58.3333333333%;
  }

  .col-xl-8 {
    flex: 0 0 66.6666666667%;
    max-width: 66.6666666667%;
  }

  .col-xl-9 {
    flex: 0 0 75%;
    max-width: 75%;
  }

  .col-xl-10 {
    flex: 0 0 83.3333333333%;
    max-width: 83.3333333333%;
  }

  .col-xl-11 {
    flex: 0 0 91.6666666667%;
    max-width: 91.6666666667%;
  }

  .col-xl-12 {
    flex: 0 0 100%;
    max-width: 100%;
  }

  .order-xl-first {
    order: -1;
  }

  .order-xl-last {
    order: 13;
  }

  .order-xl-0 {
    order: 0;
  }

  .order-xl-1 {
    order: 1;
  }

  .order-xl-2 {
    order: 2;
  }

  .order-xl-3 {
    order: 3;
  }

  .order-xl-4 {
    order: 4;
  }

  .order-xl-5 {
    order: 5;
  }

  .order-xl-6 {
    order: 6;
  }

  .order-xl-7 {
    order: 7;
  }

  .order-xl-8 {
    order: 8;
  }

  .order-xl-9 {
    order: 9;
  }

  .order-xl-10 {
    order: 10;
  }

  .order-xl-11 {
    order: 11;
  }

  .order-xl-12 {
    order: 12;
  }

  .offset-xl-0 {
    margin-left: 0;
  }

  .offset-xl-1 {
    margin-left: 8.3333333333%;
  }

  .offset-xl-2 {
    margin-left: 16.6666666667%;
  }

  .offset-xl-3 {
    margin-left: 25%;
  }

  .offset-xl-4 {
    margin-left: 33.3333333333%;
  }

  .offset-xl-5 {
    margin-left: 41.6666666667%;
  }

  .offset-xl-6 {
    margin-left: 50%;
  }

  .offset-xl-7 {
    margin-left: 58.3333333333%;
  }

  .offset-xl-8 {
    margin-left: 66.6666666667%;
  }

  .offset-xl-9 {
    margin-left: 75%;
  }

  .offset-xl-10 {
    margin-left: 83.3333333333%;
  }

  .offset-xl-11 {
    margin-left: 91.6666666667%;
  }
}

.table {
  width: 100%;
  margin-bottom: 1rem;
  color: #212529;
}

.table th,
.table td {
  padding: 0.75rem;
  vertical-align: top;
  border-top: 1px solid #dee2e6;
}

.table thead th {
  vertical-align: bottom;
  border-bottom: 2px solid #dee2e6;
}

.table tbody + tbody {
  border-top: 2px solid #dee2e6;
}

.table-sm th,
.table-sm td {
  padding: 0.3rem;
}

.table-bordered {
  border: 1px solid #dee2e6;
}

.table-bordered th,
.table-bordered td {
  border: 1px solid #dee2e6;
}

.table-bordered thead th,
.table-bordered thead td {
  border-bottom-width: 2px;
}

.table-borderless th,
.table-borderless td,
.table-borderless thead th,
.table-borderless tbody + tbody {
  border: 0;
}

.table-striped tbody tr:nth-of-type(odd) {
  background-color: rgba(0, 0, 0, 0.05);
}

.table-hover tbody tr:hover {
  color: #212529;
  background-color: rgba(0, 0, 0, 0.075);
}

.table-primary,
.table-primary > th,
.table-primary > td {
  background-color: #c6e0f5;
}

.table-primary th,
.table-primary td,
.table-primary thead th,
.table-primary tbody + tbody {
  border-color: #95c5ed;
}

.table-hover .table-primary:hover {
  background-color: #b0d4f1;
}

.table-hover .table-primary:hover > td,
.table-hover .table-primary:hover > th {
  background-color: #b0d4f1;
}

.table-secondary,
.table-secondary > th,
.table-secondary > td {
  background-color: #d6d8db;
}

.table-secondary th,
.table-secondary td,
.table-secondary thead th,
.table-secondary tbody + tbody {
  border-color: #b3b7bb;
}

.table-hover .table-secondary:hover {
  background-color: #c8cbcf;
}

.table-hover .table-secondary:hover > td,
.table-hover .table-secondary:hover > th {
  background-color: #c8cbcf;
}

.table-success,
.table-success > th,
.table-success > td {
  background-color: #c7eed8;
}

.table-success th,
.table-success td,
.table-success thead th,
.table-success tbody + tbody {
  border-color: #98dfb6;
}

.table-hover .table-success:hover {
  background-color: #b3e8ca;
}

.table-hover .table-success:hover > td,
.table-hover .table-success:hover > th {
  background-color: #b3e8ca;
}

.table-info,
.table-info > th,
.table-info > td {
  background-color: #d6e9f9;
}

.table-info th,
.table-info td,
.table-info thead th,
.table-info tbody + tbody {
  border-color: #b3d7f5;
}

.table-hover .table-info:hover {
  background-color: #c0ddf6;
}

.table-hover .table-info:hover > td,
.table-hover .table-info:hover > th {
  background-color: #c0ddf6;
}

.table-warning,
.table-warning > th,
.table-warning > td {
  background-color: #fffacc;
}

.table-warning th,
.table-warning td,
.table-warning thead th,
.table-warning tbody + tbody {
  border-color: #fff6a1;
}

.table-hover .table-warning:hover {
  background-color: #fff8b3;
}

.table-hover .table-warning:hover > td,
.table-hover .table-warning:hover > th {
  background-color: #fff8b3;
}

.table-danger,
.table-danger > th,
.table-danger > td {
  background-color: #f7c6c5;
}

.table-danger th,
.table-danger td,
.table-danger thead th,
.table-danger tbody + tbody {
  border-color: #f09593;
}

.table-hover .table-danger:hover {
  background-color: #f4b0af;
}

.table-hover .table-danger:hover > td,
.table-hover .table-danger:hover > th {
  background-color: #f4b0af;
}

.table-light,
.table-light > th,
.table-light > td {
  background-color: #fdfdfe;
}

.table-light th,
.table-light td,
.table-light thead th,
.table-light tbody + tbody {
  border-color: #fbfcfc;
}

.table-hover .table-light:hover {
  background-color: #ececf6;
}

.table-hover .table-light:hover > td,
.table-hover .table-light:hover > th {
  background-color: #ececf6;
}

.table-dark,
.table-dark > th,
.table-dark > td {
  background-color: #c6c8ca;
}

.table-dark th,
.table-dark td,
.table-dark thead th,
.table-dark tbody + tbody {
  border-color: #95999c;
}

.table-hover .table-dark:hover {
  background-color: #b9bbbe;
}

.table-hover .table-dark:hover > td,
.table-hover .table-dark:hover > th {
  background-color: #b9bbbe;
}

.table-active,
.table-active > th,
.table-active > td {
  background-color: rgba(0, 0, 0, 0.075);
}

.table-hover .table-active:hover {
  background-color: rgba(0, 0, 0, 0.075);
}

.table-hover .table-active:hover > td,
.table-hover .table-active:hover > th {
  background-color: rgba(0, 0, 0, 0.075);
}

.table .thead-dark th {
  color: #fff;
  background-color: #343a40;
  border-color: #454d55;
}

.table .thead-light th {
  color: #495057;
  background-color: #e9ecef;
  border-color: #dee2e6;
}

.table-dark {
  color: #fff;
  background-color: #343a40;
}

.table-dark th,
.table-dark td,
.table-dark thead th {
  border-color: #454d55;
}

.table-dark.table-bordered {
  border: 0;
}

.table-dark.table-striped tbody tr:nth-of-type(odd) {
  background-color: rgba(255, 255, 255, 0.05);
}

.table-dark.table-hover tbody tr:hover {
  color: #fff;
  background-color: rgba(255, 255, 255, 0.075);
}

@media (max-width: 575.98px) {
  .table-responsive-sm {
    display: block;
    width: 100%;
    overflow-x: auto;
    -webkit-overflow-scrolling: touch;
  }

  .table-responsive-sm > .table-bordered {
    border: 0;
  }
}

@media (max-width: 767.98px) {
  .table-responsive-md {
    display: block;
    width: 100%;
    overflow-x: auto;
    -webkit-overflow-scrolling: touch;
  }

  .table-responsive-md > .table-bordered {
    border: 0;
  }
}

@media (max-width: 991.98px) {
  .table-responsive-lg {
    display: block;
    width: 100%;
    overflow-x: auto;
    -webkit-overflow-scrolling: touch;
  }

  .table-responsive-lg > .table-bordered {
    border: 0;
  }
}

@media (max-width: 1199.98px) {
  .table-responsive-xl {
    display: block;
    width: 100%;
    overflow-x: auto;
    -webkit-overflow-scrolling: touch;
  }

  .table-responsive-xl > .table-bordered {
    border: 0;
  }
}

.table-responsive {
  display: block;
  width: 100%;
  overflow-x: auto;
  -webkit-overflow-scrolling: touch;
}

.table-responsive > .table-bordered {
  border: 0;
}

.form-control {
  display: block;
  width: 100%;
  height: calc(1.6em + 0.75rem + 2px);
  padding: 0.375rem 0.75rem;
  font-size: 0.9rem;
  font-weight: 400;
  line-height: 1.6;
  color: #495057;
  background-color: #fff;
  background-clip: padding-box;
  border: 1px solid #ced4da;
  border-radius: 0.25rem;
  transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

@media (prefers-reduced-motion: reduce) {
  .form-control {
    transition: none;
  }
}

.form-control::-ms-expand {
  background-color: transparent;
  border: 0;
}

.form-control:-moz-focusring {
  color: transparent;
  text-shadow: 0 0 0 #495057;
}

.form-control:focus {
  color: #495057;
  background-color: #fff;
  border-color: #a1cbef;
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.form-control::-moz-placeholder {
  color: #6c757d;
  opacity: 1;
}

.form-control:-ms-input-placeholder {
  color: #6c757d;
  opacity: 1;
}

.form-control::placeholder {
  color: #6c757d;
  opacity: 1;
}

.form-control:disabled,
.form-control[readonly] {
  background-color: #e9ecef;
  opacity: 1;
}

input[type=date].form-control,
input[type=time].form-control,
input[type=datetime-local].form-control,
input[type=month].form-control {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

select.form-control:focus::-ms-value {
  color: #495057;
  background-color: #fff;
}

.form-control-file,
.form-control-range {
  display: block;
  width: 100%;
}

.col-form-label {
  padding-top: calc(0.375rem + 1px);
  padding-bottom: calc(0.375rem + 1px);
  margin-bottom: 0;
  font-size: inherit;
  line-height: 1.6;
}

.col-form-label-lg {
  padding-top: calc(0.5rem + 1px);
  padding-bottom: calc(0.5rem + 1px);
  font-size: 1.125rem;
  line-height: 1.5;
}

.col-form-label-sm {
  padding-top: calc(0.25rem + 1px);
  padding-bottom: calc(0.25rem + 1px);
  font-size: 0.7875rem;
  line-height: 1.5;
}

.form-control-plaintext {
  display: block;
  width: 100%;
  padding: 0.375rem 0;
  margin-bottom: 0;
  font-size: 0.9rem;
  line-height: 1.6;
  color: #212529;
  background-color: transparent;
  border: solid transparent;
  border-width: 1px 0;
}

.form-control-plaintext.form-control-sm,
.form-control-plaintext.form-control-lg {
  padding-right: 0;
  padding-left: 0;
}

.form-control-sm {
  height: calc(1.5em + 0.5rem + 2px);
  padding: 0.25rem 0.5rem;
  font-size: 0.7875rem;
  line-height: 1.5;
  border-radius: 0.2rem;
}

.form-control-lg {
  height: calc(1.5em + 1rem + 2px);
  padding: 0.5rem 1rem;
  font-size: 1.125rem;
  line-height: 1.5;
  border-radius: 0.3rem;
}

select.form-control[size],
select.form-control[multiple] {
  height: auto;
}

textarea.form-control {
  height: auto;
}

.form-group {
  margin-bottom: 1rem;
}

.form-text {
  display: block;
  margin-top: 0.25rem;
}

.form-row {
  display: flex;
  flex-wrap: wrap;
  margin-right: -5px;
  margin-left: -5px;
}

.form-row > .col,
.form-row > [class*=col-] {
  padding-right: 5px;
  padding-left: 5px;
}

.form-check {
  position: relative;
  display: block;
  padding-left: 1.25rem;
}

.form-check-input {
  position: absolute;
  margin-top: 0.3rem;
  margin-left: -1.25rem;
}

.form-check-input[disabled] ~ .form-check-label,
.form-check-input:disabled ~ .form-check-label {
  color: #6c757d;
}

.form-check-label {
  margin-bottom: 0;
}

.form-check-inline {
  display: inline-flex;
  align-items: center;
  padding-left: 0;
  margin-right: 0.75rem;
}

.form-check-inline .form-check-input {
  position: static;
  margin-top: 0;
  margin-right: 0.3125rem;
  margin-left: 0;
}

.valid-feedback {
  display: none;
  width: 100%;
  margin-top: 0.25rem;
  font-size: 80%;
  color: #38c172;
}

.valid-tooltip {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 5;
  display: none;
  max-width: 100%;
  padding: 0.25rem 0.5rem;
  margin-top: 0.1rem;
  font-size: 0.7875rem;
  line-height: 1.6;
  color: #fff;
  background-color: rgba(56, 193, 114, 0.9);
  border-radius: 0.25rem;
}

.was-validated :valid ~ .valid-feedback,
.was-validated :valid ~ .valid-tooltip,
.is-valid ~ .valid-feedback,
.is-valid ~ .valid-tooltip {
  display: block;
}

.was-validated .form-control:valid,
.form-control.is-valid {
  border-color: #38c172;
  padding-right: calc(1.6em + 0.75rem);
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath fill='%2338c172' d='M2.3 6.73L.6 4.53c-.4-1.04.46-1.4 1.1-.8l1.1 1.4 3.4-3.8c.6-.63 1.6-.27 1.2.7l-4 4.6c-.43.5-.8.4-1.1.1z'/%3e%3c/svg%3e");
  background-repeat: no-repeat;
  background-position: right calc(0.4em + 0.1875rem) center;
  background-size: calc(0.8em + 0.375rem) calc(0.8em + 0.375rem);
}

.was-validated .form-control:valid:focus,
.form-control.is-valid:focus {
  border-color: #38c172;
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.25);
}

.was-validated textarea.form-control:valid,
textarea.form-control.is-valid {
  padding-right: calc(1.6em + 0.75rem);
  background-position: top calc(0.4em + 0.1875rem) right calc(0.4em + 0.1875rem);
}

.was-validated .custom-select:valid,
.custom-select.is-valid {
  border-color: #38c172;
  padding-right: calc(0.75em + 2.3125rem);
  background: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='4' height='5' viewBox='0 0 4 5'%3e%3cpath fill='%23343a40' d='M2 0L0 2h4zm0 5L0 3h4z'/%3e%3c/svg%3e") no-repeat right 0.75rem center/8px 10px, url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath fill='%2338c172' d='M2.3 6.73L.6 4.53c-.4-1.04.46-1.4 1.1-.8l1.1 1.4 3.4-3.8c.6-.63 1.6-.27 1.2.7l-4 4.6c-.43.5-.8.4-1.1.1z'/%3e%3c/svg%3e") #fff no-repeat center right 1.75rem/calc(0.8em + 0.375rem) calc(0.8em + 0.375rem);
}

.was-validated .custom-select:valid:focus,
.custom-select.is-valid:focus {
  border-color: #38c172;
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.25);
}

.was-validated .form-check-input:valid ~ .form-check-label,
.form-check-input.is-valid ~ .form-check-label {
  color: #38c172;
}

.was-validated .form-check-input:valid ~ .valid-feedback,
.was-validated .form-check-input:valid ~ .valid-tooltip,
.form-check-input.is-valid ~ .valid-feedback,
.form-check-input.is-valid ~ .valid-tooltip {
  display: block;
}

.was-validated .custom-control-input:valid ~ .custom-control-label,
.custom-control-input.is-valid ~ .custom-control-label {
  color: #38c172;
}

.was-validated .custom-control-input:valid ~ .custom-control-label::before,
.custom-control-input.is-valid ~ .custom-control-label::before {
  border-color: #38c172;
}

.was-validated .custom-control-input:valid:checked ~ .custom-control-label::before,
.custom-control-input.is-valid:checked ~ .custom-control-label::before {
  border-color: #5cd08d;
  background-color: #5cd08d;
}

.was-validated .custom-control-input:valid:focus ~ .custom-control-label::before,
.custom-control-input.is-valid:focus ~ .custom-control-label::before {
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.25);
}

.was-validated .custom-control-input:valid:focus:not(:checked) ~ .custom-control-label::before,
.custom-control-input.is-valid:focus:not(:checked) ~ .custom-control-label::before {
  border-color: #38c172;
}

.was-validated .custom-file-input:valid ~ .custom-file-label,
.custom-file-input.is-valid ~ .custom-file-label {
  border-color: #38c172;
}

.was-validated .custom-file-input:valid:focus ~ .custom-file-label,
.custom-file-input.is-valid:focus ~ .custom-file-label {
  border-color: #38c172;
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.25);
}

.invalid-feedback {
  display: none;
  width: 100%;
  margin-top: 0.25rem;
  font-size: 80%;
  color: #e3342f;
}

.invalid-tooltip {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 5;
  display: none;
  max-width: 100%;
  padding: 0.25rem 0.5rem;
  margin-top: 0.1rem;
  font-size: 0.7875rem;
  line-height: 1.6;
  color: #fff;
  background-color: rgba(227, 52, 47, 0.9);
  border-radius: 0.25rem;
}

.was-validated :invalid ~ .invalid-feedback,
.was-validated :invalid ~ .invalid-tooltip,
.is-invalid ~ .invalid-feedback,
.is-invalid ~ .invalid-tooltip {
  display: block;
}

.was-validated .form-control:invalid,
.form-control.is-invalid {
  border-color: #e3342f;
  padding-right: calc(1.6em + 0.75rem);
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='12' height='12' fill='none' stroke='%23e3342f' viewBox='0 0 12 12'%3e%3ccircle cx='6' cy='6' r='4.5'/%3e%3cpath stroke-linejoin='round' d='M5.8 3.6h.4L6 6.5z'/%3e%3ccircle cx='6' cy='8.2' r='.6' fill='%23e3342f' stroke='none'/%3e%3c/svg%3e");
  background-repeat: no-repeat;
  background-position: right calc(0.4em + 0.1875rem) center;
  background-size: calc(0.8em + 0.375rem) calc(0.8em + 0.375rem);
}

.was-validated .form-control:invalid:focus,
.form-control.is-invalid:focus {
  border-color: #e3342f;
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.25);
}

.was-validated textarea.form-control:invalid,
textarea.form-control.is-invalid {
  padding-right: calc(1.6em + 0.75rem);
  background-position: top calc(0.4em + 0.1875rem) right calc(0.4em + 0.1875rem);
}

.was-validated .custom-select:invalid,
.custom-select.is-invalid {
  border-color: #e3342f;
  padding-right: calc(0.75em + 2.3125rem);
  background: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='4' height='5' viewBox='0 0 4 5'%3e%3cpath fill='%23343a40' d='M2 0L0 2h4zm0 5L0 3h4z'/%3e%3c/svg%3e") no-repeat right 0.75rem center/8px 10px, url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='12' height='12' fill='none' stroke='%23e3342f' viewBox='0 0 12 12'%3e%3ccircle cx='6' cy='6' r='4.5'/%3e%3cpath stroke-linejoin='round' d='M5.8 3.6h.4L6 6.5z'/%3e%3ccircle cx='6' cy='8.2' r='.6' fill='%23e3342f' stroke='none'/%3e%3c/svg%3e") #fff no-repeat center right 1.75rem/calc(0.8em + 0.375rem) calc(0.8em + 0.375rem);
}

.was-validated .custom-select:invalid:focus,
.custom-select.is-invalid:focus {
  border-color: #e3342f;
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.25);
}

.was-validated .form-check-input:invalid ~ .form-check-label,
.form-check-input.is-invalid ~ .form-check-label {
  color: #e3342f;
}

.was-validated .form-check-input:invalid ~ .invalid-feedback,
.was-validated .form-check-input:invalid ~ .invalid-tooltip,
.form-check-input.is-invalid ~ .invalid-feedback,
.form-check-input.is-invalid ~ .invalid-tooltip {
  display: block;
}

.was-validated .custom-control-input:invalid ~ .custom-control-label,
.custom-control-input.is-invalid ~ .custom-control-label {
  color: #e3342f;
}

.was-validated .custom-control-input:invalid ~ .custom-control-label::before,
.custom-control-input.is-invalid ~ .custom-control-label::before {
  border-color: #e3342f;
}

.was-validated .custom-control-input:invalid:checked ~ .custom-control-label::before,
.custom-control-input.is-invalid:checked ~ .custom-control-label::before {
  border-color: #e9605c;
  background-color: #e9605c;
}

.was-validated .custom-control-input:invalid:focus ~ .custom-control-label::before,
.custom-control-input.is-invalid:focus ~ .custom-control-label::before {
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.25);
}

.was-validated .custom-control-input:invalid:focus:not(:checked) ~ .custom-control-label::before,
.custom-control-input.is-invalid:focus:not(:checked) ~ .custom-control-label::before {
  border-color: #e3342f;
}

.was-validated .custom-file-input:invalid ~ .custom-file-label,
.custom-file-input.is-invalid ~ .custom-file-label {
  border-color: #e3342f;
}

.was-validated .custom-file-input:invalid:focus ~ .custom-file-label,
.custom-file-input.is-invalid:focus ~ .custom-file-label {
  border-color: #e3342f;
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.25);
}

.form-inline {
  display: flex;
  flex-flow: row wrap;
  align-items: center;
}

.form-inline .form-check {
  width: 100%;
}

@media (min-width: 576px) {
  .form-inline label {
    display: flex;
    align-items: center;
    justify-content: center;
    margin-bottom: 0;
  }

  .form-inline .form-group {
    display: flex;
    flex: 0 0 auto;
    flex-flow: row wrap;
    align-items: center;
    margin-bottom: 0;
  }

  .form-inline .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle;
  }

  .form-inline .form-control-plaintext {
    display: inline-block;
  }

  .form-inline .input-group,
  .form-inline .custom-select {
    width: auto;
  }

  .form-inline .form-check {
    display: flex;
    align-items: center;
    justify-content: center;
    width: auto;
    padding-left: 0;
  }

  .form-inline .form-check-input {
    position: relative;
    flex-shrink: 0;
    margin-top: 0;
    margin-right: 0.25rem;
    margin-left: 0;
  }

  .form-inline .custom-control {
    align-items: center;
    justify-content: center;
  }

  .form-inline .custom-control-label {
    margin-bottom: 0;
  }
}

.btn {
  display: inline-block;
  font-weight: 400;
  color: #212529;
  text-align: center;
  vertical-align: middle;
  -webkit-user-select: none;
     -moz-user-select: none;
      -ms-user-select: none;
          user-select: none;
  background-color: transparent;
  border: 1px solid transparent;
  padding: 0.375rem 0.75rem;
  font-size: 0.9rem;
  line-height: 1.6;
  border-radius: 0.25rem;
  transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

@media (prefers-reduced-motion: reduce) {
  .btn {
    transition: none;
  }
}

.btn:hover {
  color: #212529;
  text-decoration: none;
}

.btn:focus,
.btn.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.btn.disabled,
.btn:disabled {
  opacity: 0.65;
}

.btn:not(:disabled):not(.disabled) {
  cursor: pointer;
}

a.btn.disabled,
fieldset:disabled a.btn {
  pointer-events: none;
}

.btn-primary {
  color: #fff;
  background-color: #3490dc;
  border-color: #3490dc;
}

.btn-primary:hover {
  color: #fff;
  background-color: #227dc7;
  border-color: #2176bd;
}

.btn-primary:focus,
.btn-primary.focus {
  color: #fff;
  background-color: #227dc7;
  border-color: #2176bd;
  box-shadow: 0 0 0 0.2rem rgba(82, 161, 225, 0.5);
}

.btn-primary.disabled,
.btn-primary:disabled {
  color: #fff;
  background-color: #3490dc;
  border-color: #3490dc;
}

.btn-primary:not(:disabled):not(.disabled):active,
.btn-primary:not(:disabled):not(.disabled).active,
.show > .btn-primary.dropdown-toggle {
  color: #fff;
  background-color: #2176bd;
  border-color: #1f6fb2;
}

.btn-primary:not(:disabled):not(.disabled):active:focus,
.btn-primary:not(:disabled):not(.disabled).active:focus,
.show > .btn-primary.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(82, 161, 225, 0.5);
}

.btn-secondary {
  color: #fff;
  background-color: #6c757d;
  border-color: #6c757d;
}

.btn-secondary:hover {
  color: #fff;
  background-color: #5a6268;
  border-color: #545b62;
}

.btn-secondary:focus,
.btn-secondary.focus {
  color: #fff;
  background-color: #5a6268;
  border-color: #545b62;
  box-shadow: 0 0 0 0.2rem rgba(130, 138, 145, 0.5);
}

.btn-secondary.disabled,
.btn-secondary:disabled {
  color: #fff;
  background-color: #6c757d;
  border-color: #6c757d;
}

.btn-secondary:not(:disabled):not(.disabled):active,
.btn-secondary:not(:disabled):not(.disabled).active,
.show > .btn-secondary.dropdown-toggle {
  color: #fff;
  background-color: #545b62;
  border-color: #4e555b;
}

.btn-secondary:not(:disabled):not(.disabled):active:focus,
.btn-secondary:not(:disabled):not(.disabled).active:focus,
.show > .btn-secondary.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(130, 138, 145, 0.5);
}

.btn-success {
  color: #fff;
  background-color: #38c172;
  border-color: #38c172;
}

.btn-success:hover {
  color: #fff;
  background-color: #2fa360;
  border-color: #2d995b;
}

.btn-success:focus,
.btn-success.focus {
  color: #fff;
  background-color: #2fa360;
  border-color: #2d995b;
  box-shadow: 0 0 0 0.2rem rgba(86, 202, 135, 0.5);
}

.btn-success.disabled,
.btn-success:disabled {
  color: #fff;
  background-color: #38c172;
  border-color: #38c172;
}

.btn-success:not(:disabled):not(.disabled):active,
.btn-success:not(:disabled):not(.disabled).active,
.show > .btn-success.dropdown-toggle {
  color: #fff;
  background-color: #2d995b;
  border-color: #2a9055;
}

.btn-success:not(:disabled):not(.disabled):active:focus,
.btn-success:not(:disabled):not(.disabled).active:focus,
.show > .btn-success.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(86, 202, 135, 0.5);
}

.btn-info {
  color: #212529;
  background-color: #6cb2eb;
  border-color: #6cb2eb;
}

.btn-info:hover {
  color: #fff;
  background-color: #4aa0e6;
  border-color: #3f9ae5;
}

.btn-info:focus,
.btn-info.focus {
  color: #fff;
  background-color: #4aa0e6;
  border-color: #3f9ae5;
  box-shadow: 0 0 0 0.2rem rgba(97, 157, 206, 0.5);
}

.btn-info.disabled,
.btn-info:disabled {
  color: #212529;
  background-color: #6cb2eb;
  border-color: #6cb2eb;
}

.btn-info:not(:disabled):not(.disabled):active,
.btn-info:not(:disabled):not(.disabled).active,
.show > .btn-info.dropdown-toggle {
  color: #fff;
  background-color: #3f9ae5;
  border-color: #3495e3;
}

.btn-info:not(:disabled):not(.disabled):active:focus,
.btn-info:not(:disabled):not(.disabled).active:focus,
.show > .btn-info.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(97, 157, 206, 0.5);
}

.btn-warning {
  color: #212529;
  background-color: #ffed4a;
  border-color: #ffed4a;
}

.btn-warning:hover {
  color: #212529;
  background-color: #ffe924;
  border-color: #ffe817;
}

.btn-warning:focus,
.btn-warning.focus {
  color: #212529;
  background-color: #ffe924;
  border-color: #ffe817;
  box-shadow: 0 0 0 0.2rem rgba(222, 207, 69, 0.5);
}

.btn-warning.disabled,
.btn-warning:disabled {
  color: #212529;
  background-color: #ffed4a;
  border-color: #ffed4a;
}

.btn-warning:not(:disabled):not(.disabled):active,
.btn-warning:not(:disabled):not(.disabled).active,
.show > .btn-warning.dropdown-toggle {
  color: #212529;
  background-color: #ffe817;
  border-color: #ffe70a;
}

.btn-warning:not(:disabled):not(.disabled):active:focus,
.btn-warning:not(:disabled):not(.disabled).active:focus,
.show > .btn-warning.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(222, 207, 69, 0.5);
}

.btn-danger {
  color: #fff;
  background-color: #e3342f;
  border-color: #e3342f;
}

.btn-danger:hover {
  color: #fff;
  background-color: #d0211c;
  border-color: #c51f1a;
}

.btn-danger:focus,
.btn-danger.focus {
  color: #fff;
  background-color: #d0211c;
  border-color: #c51f1a;
  box-shadow: 0 0 0 0.2rem rgba(231, 82, 78, 0.5);
}

.btn-danger.disabled,
.btn-danger:disabled {
  color: #fff;
  background-color: #e3342f;
  border-color: #e3342f;
}

.btn-danger:not(:disabled):not(.disabled):active,
.btn-danger:not(:disabled):not(.disabled).active,
.show > .btn-danger.dropdown-toggle {
  color: #fff;
  background-color: #c51f1a;
  border-color: #b91d19;
}

.btn-danger:not(:disabled):not(.disabled):active:focus,
.btn-danger:not(:disabled):not(.disabled).active:focus,
.show > .btn-danger.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(231, 82, 78, 0.5);
}

.btn-light {
  color: #212529;
  background-color: #f8f9fa;
  border-color: #f8f9fa;
}

.btn-light:hover {
  color: #212529;
  background-color: #e2e6ea;
  border-color: #dae0e5;
}

.btn-light:focus,
.btn-light.focus {
  color: #212529;
  background-color: #e2e6ea;
  border-color: #dae0e5;
  box-shadow: 0 0 0 0.2rem rgba(216, 217, 219, 0.5);
}

.btn-light.disabled,
.btn-light:disabled {
  color: #212529;
  background-color: #f8f9fa;
  border-color: #f8f9fa;
}

.btn-light:not(:disabled):not(.disabled):active,
.btn-light:not(:disabled):not(.disabled).active,
.show > .btn-light.dropdown-toggle {
  color: #212529;
  background-color: #dae0e5;
  border-color: #d3d9df;
}

.btn-light:not(:disabled):not(.disabled):active:focus,
.btn-light:not(:disabled):not(.disabled).active:focus,
.show > .btn-light.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(216, 217, 219, 0.5);
}

.btn-dark {
  color: #fff;
  background-color: #343a40;
  border-color: #343a40;
}

.btn-dark:hover {
  color: #fff;
  background-color: #23272b;
  border-color: #1d2124;
}

.btn-dark:focus,
.btn-dark.focus {
  color: #fff;
  background-color: #23272b;
  border-color: #1d2124;
  box-shadow: 0 0 0 0.2rem rgba(82, 88, 93, 0.5);
}

.btn-dark.disabled,
.btn-dark:disabled {
  color: #fff;
  background-color: #343a40;
  border-color: #343a40;
}

.btn-dark:not(:disabled):not(.disabled):active,
.btn-dark:not(:disabled):not(.disabled).active,
.show > .btn-dark.dropdown-toggle {
  color: #fff;
  background-color: #1d2124;
  border-color: #171a1d;
}

.btn-dark:not(:disabled):not(.disabled):active:focus,
.btn-dark:not(:disabled):not(.disabled).active:focus,
.show > .btn-dark.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(82, 88, 93, 0.5);
}

.btn-outline-primary {
  color: #3490dc;
  border-color: #3490dc;
}

.btn-outline-primary:hover {
  color: #fff;
  background-color: #3490dc;
  border-color: #3490dc;
}

.btn-outline-primary:focus,
.btn-outline-primary.focus {
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.5);
}

.btn-outline-primary.disabled,
.btn-outline-primary:disabled {
  color: #3490dc;
  background-color: transparent;
}

.btn-outline-primary:not(:disabled):not(.disabled):active,
.btn-outline-primary:not(:disabled):not(.disabled).active,
.show > .btn-outline-primary.dropdown-toggle {
  color: #fff;
  background-color: #3490dc;
  border-color: #3490dc;
}

.btn-outline-primary:not(:disabled):not(.disabled):active:focus,
.btn-outline-primary:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-primary.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.5);
}

.btn-outline-secondary {
  color: #6c757d;
  border-color: #6c757d;
}

.btn-outline-secondary:hover {
  color: #fff;
  background-color: #6c757d;
  border-color: #6c757d;
}

.btn-outline-secondary:focus,
.btn-outline-secondary.focus {
  box-shadow: 0 0 0 0.2rem rgba(108, 117, 125, 0.5);
}

.btn-outline-secondary.disabled,
.btn-outline-secondary:disabled {
  color: #6c757d;
  background-color: transparent;
}

.btn-outline-secondary:not(:disabled):not(.disabled):active,
.btn-outline-secondary:not(:disabled):not(.disabled).active,
.show > .btn-outline-secondary.dropdown-toggle {
  color: #fff;
  background-color: #6c757d;
  border-color: #6c757d;
}

.btn-outline-secondary:not(:disabled):not(.disabled):active:focus,
.btn-outline-secondary:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-secondary.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(108, 117, 125, 0.5);
}

.btn-outline-success {
  color: #38c172;
  border-color: #38c172;
}

.btn-outline-success:hover {
  color: #fff;
  background-color: #38c172;
  border-color: #38c172;
}

.btn-outline-success:focus,
.btn-outline-success.focus {
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.5);
}

.btn-outline-success.disabled,
.btn-outline-success:disabled {
  color: #38c172;
  background-color: transparent;
}

.btn-outline-success:not(:disabled):not(.disabled):active,
.btn-outline-success:not(:disabled):not(.disabled).active,
.show > .btn-outline-success.dropdown-toggle {
  color: #fff;
  background-color: #38c172;
  border-color: #38c172;
}

.btn-outline-success:not(:disabled):not(.disabled):active:focus,
.btn-outline-success:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-success.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.5);
}

.btn-outline-info {
  color: #6cb2eb;
  border-color: #6cb2eb;
}

.btn-outline-info:hover {
  color: #212529;
  background-color: #6cb2eb;
  border-color: #6cb2eb;
}

.btn-outline-info:focus,
.btn-outline-info.focus {
  box-shadow: 0 0 0 0.2rem rgba(108, 178, 235, 0.5);
}

.btn-outline-info.disabled,
.btn-outline-info:disabled {
  color: #6cb2eb;
  background-color: transparent;
}

.btn-outline-info:not(:disabled):not(.disabled):active,
.btn-outline-info:not(:disabled):not(.disabled).active,
.show > .btn-outline-info.dropdown-toggle {
  color: #212529;
  background-color: #6cb2eb;
  border-color: #6cb2eb;
}

.btn-outline-info:not(:disabled):not(.disabled):active:focus,
.btn-outline-info:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-info.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(108, 178, 235, 0.5);
}

.btn-outline-warning {
  color: #ffed4a;
  border-color: #ffed4a;
}

.btn-outline-warning:hover {
  color: #212529;
  background-color: #ffed4a;
  border-color: #ffed4a;
}

.btn-outline-warning:focus,
.btn-outline-warning.focus {
  box-shadow: 0 0 0 0.2rem rgba(255, 237, 74, 0.5);
}

.btn-outline-warning.disabled,
.btn-outline-warning:disabled {
  color: #ffed4a;
  background-color: transparent;
}

.btn-outline-warning:not(:disabled):not(.disabled):active,
.btn-outline-warning:not(:disabled):not(.disabled).active,
.show > .btn-outline-warning.dropdown-toggle {
  color: #212529;
  background-color: #ffed4a;
  border-color: #ffed4a;
}

.btn-outline-warning:not(:disabled):not(.disabled):active:focus,
.btn-outline-warning:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-warning.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(255, 237, 74, 0.5);
}

.btn-outline-danger {
  color: #e3342f;
  border-color: #e3342f;
}

.btn-outline-danger:hover {
  color: #fff;
  background-color: #e3342f;
  border-color: #e3342f;
}

.btn-outline-danger:focus,
.btn-outline-danger.focus {
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.5);
}

.btn-outline-danger.disabled,
.btn-outline-danger:disabled {
  color: #e3342f;
  background-color: transparent;
}

.btn-outline-danger:not(:disabled):not(.disabled):active,
.btn-outline-danger:not(:disabled):not(.disabled).active,
.show > .btn-outline-danger.dropdown-toggle {
  color: #fff;
  background-color: #e3342f;
  border-color: #e3342f;
}

.btn-outline-danger:not(:disabled):not(.disabled):active:focus,
.btn-outline-danger:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-danger.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.5);
}

.btn-outline-light {
  color: #f8f9fa;
  border-color: #f8f9fa;
}

.btn-outline-light:hover {
  color: #212529;
  background-color: #f8f9fa;
  border-color: #f8f9fa;
}

.btn-outline-light:focus,
.btn-outline-light.focus {
  box-shadow: 0 0 0 0.2rem rgba(248, 249, 250, 0.5);
}

.btn-outline-light.disabled,
.btn-outline-light:disabled {
  color: #f8f9fa;
  background-color: transparent;
}

.btn-outline-light:not(:disabled):not(.disabled):active,
.btn-outline-light:not(:disabled):not(.disabled).active,
.show > .btn-outline-light.dropdown-toggle {
  color: #212529;
  background-color: #f8f9fa;
  border-color: #f8f9fa;
}

.btn-outline-light:not(:disabled):not(.disabled):active:focus,
.btn-outline-light:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-light.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(248, 249, 250, 0.5);
}

.btn-outline-dark {
  color: #343a40;
  border-color: #343a40;
}

.btn-outline-dark:hover {
  color: #fff;
  background-color: #343a40;
  border-color: #343a40;
}

.btn-outline-dark:focus,
.btn-outline-dark.focus {
  box-shadow: 0 0 0 0.2rem rgba(52, 58, 64, 0.5);
}

.btn-outline-dark.disabled,
.btn-outline-dark:disabled {
  color: #343a40;
  background-color: transparent;
}

.btn-outline-dark:not(:disabled):not(.disabled):active,
.btn-outline-dark:not(:disabled):not(.disabled).active,
.show > .btn-outline-dark.dropdown-toggle {
  color: #fff;
  background-color: #343a40;
  border-color: #343a40;
}

.btn-outline-dark:not(:disabled):not(.disabled):active:focus,
.btn-outline-dark:not(:disabled):not(.disabled).active:focus,
.show > .btn-outline-dark.dropdown-toggle:focus {
  box-shadow: 0 0 0 0.2rem rgba(52, 58, 64, 0.5);
}

.btn-link {
  font-weight: 400;
  color: #3490dc;
  text-decoration: none;
}

.btn-link:hover {
  color: #1d68a7;
  text-decoration: underline;
}

.btn-link:focus,
.btn-link.focus {
  text-decoration: underline;
}

.btn-link:disabled,
.btn-link.disabled {
  color: #6c757d;
  pointer-events: none;
}

.btn-lg,
.btn-group-lg > .btn {
  padding: 0.5rem 1rem;
  font-size: 1.125rem;
  line-height: 1.5;
  border-radius: 0.3rem;
}

.btn-sm,
.btn-group-sm > .btn {
  padding: 0.25rem 0.5rem;
  font-size: 0.7875rem;
  line-height: 1.5;
  border-radius: 0.2rem;
}

.btn-block {
  display: block;
  width: 100%;
}

.btn-block + .btn-block {
  margin-top: 0.5rem;
}

input[type=submit].btn-block,
input[type=reset].btn-block,
input[type=button].btn-block {
  width: 100%;
}

.fade {
  transition: opacity 0.15s linear;
}

@media (prefers-reduced-motion: reduce) {
  .fade {
    transition: none;
  }
}

.fade:not(.show) {
  opacity: 0;
}

.collapse:not(.show) {
  display: none;
}

.collapsing {
  position: relative;
  height: 0;
  overflow: hidden;
  transition: height 0.35s ease;
}

@media (prefers-reduced-motion: reduce) {
  .collapsing {
    transition: none;
  }
}

.dropup,
.dropright,
.dropdown,
.dropleft {
  position: relative;
}

.dropdown-toggle {
  white-space: nowrap;
}

.dropdown-toggle::after {
  display: inline-block;
  margin-left: 0.255em;
  vertical-align: 0.255em;
  content: "";
  border-top: 0.3em solid;
  border-right: 0.3em solid transparent;
  border-bottom: 0;
  border-left: 0.3em solid transparent;
}

.dropdown-toggle:empty::after {
  margin-left: 0;
}

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 1000;
  display: none;
  float: left;
  min-width: 10rem;
  padding: 0.5rem 0;
  margin: 0.125rem 0 0;
  font-size: 0.9rem;
  color: #212529;
  text-align: left;
  list-style: none;
  background-color: #fff;
  background-clip: padding-box;
  border: 1px solid rgba(0, 0, 0, 0.15);
  border-radius: 0.25rem;
}

.dropdown-menu-left {
  right: auto;
  left: 0;
}

.dropdown-menu-right {
  right: 0;
  left: auto;
}

@media (min-width: 576px) {
  .dropdown-menu-sm-left {
    right: auto;
    left: 0;
  }

  .dropdown-menu-sm-right {
    right: 0;
    left: auto;
  }
}

@media (min-width: 768px) {
  .dropdown-menu-md-left {
    right: auto;
    left: 0;
  }

  .dropdown-menu-md-right {
    right: 0;
    left: auto;
  }
}

@media (min-width: 992px) {
  .dropdown-menu-lg-left {
    right: auto;
    left: 0;
  }

  .dropdown-menu-lg-right {
    right: 0;
    left: auto;
  }
}

@media (min-width: 1200px) {
  .dropdown-menu-xl-left {
    right: auto;
    left: 0;
  }

  .dropdown-menu-xl-right {
    right: 0;
    left: auto;
  }
}

.dropup .dropdown-menu {
  top: auto;
  bottom: 100%;
  margin-top: 0;
  margin-bottom: 0.125rem;
}

.dropup .dropdown-toggle::after {
  display: inline-block;
  margin-left: 0.255em;
  vertical-align: 0.255em;
  content: "";
  border-top: 0;
  border-right: 0.3em solid transparent;
  border-bottom: 0.3em solid;
  border-left: 0.3em solid transparent;
}

.dropup .dropdown-toggle:empty::after {
  margin-left: 0;
}

.dropright .dropdown-menu {
  top: 0;
  right: auto;
  left: 100%;
  margin-top: 0;
  margin-left: 0.125rem;
}

.dropright .dropdown-toggle::after {
  display: inline-block;
  margin-left: 0.255em;
  vertical-align: 0.255em;
  content: "";
  border-top: 0.3em solid transparent;
  border-right: 0;
  border-bottom: 0.3em solid transparent;
  border-left: 0.3em solid;
}

.dropright .dropdown-toggle:empty::after {
  margin-left: 0;
}

.dropright .dropdown-toggle::after {
  vertical-align: 0;
}

.dropleft .dropdown-menu {
  top: 0;
  right: 100%;
  left: auto;
  margin-top: 0;
  margin-right: 0.125rem;
}

.dropleft .dropdown-toggle::after {
  display: inline-block;
  margin-left: 0.255em;
  vertical-align: 0.255em;
  content: "";
}

.dropleft .dropdown-toggle::after {
  display: none;
}

.dropleft .dropdown-toggle::before {
  display: inline-block;
  margin-right: 0.255em;
  vertical-align: 0.255em;
  content: "";
  border-top: 0.3em solid transparent;
  border-right: 0.3em solid;
  border-bottom: 0.3em solid transparent;
}

.dropleft .dropdown-toggle:empty::after {
  margin-left: 0;
}

.dropleft .dropdown-toggle::before {
  vertical-align: 0;
}

.dropdown-menu[x-placement^=top],
.dropdown-menu[x-placement^=right],
.dropdown-menu[x-placement^=bottom],
.dropdown-menu[x-placement^=left] {
  right: auto;
  bottom: auto;
}

.dropdown-divider {
  height: 0;
  margin: 0.5rem 0;
  overflow: hidden;
  border-top: 1px solid #e9ecef;
}

.dropdown-item {
  display: block;
  width: 100%;
  padding: 0.25rem 1.5rem;
  clear: both;
  font-weight: 400;
  color: #212529;
  text-align: inherit;
  white-space: nowrap;
  background-color: transparent;
  border: 0;
}

.dropdown-item:hover,
.dropdown-item:focus {
  color: #16181b;
  text-decoration: none;
  background-color: #f8f9fa;
}

.dropdown-item.active,
.dropdown-item:active {
  color: #fff;
  text-decoration: none;
  background-color: #3490dc;
}

.dropdown-item.disabled,
.dropdown-item:disabled {
  color: #6c757d;
  pointer-events: none;
  background-color: transparent;
}

.dropdown-menu.show {
  display: block;
}

.dropdown-header {
  display: block;
  padding: 0.5rem 1.5rem;
  margin-bottom: 0;
  font-size: 0.7875rem;
  color: #6c757d;
  white-space: nowrap;
}

.dropdown-item-text {
  display: block;
  padding: 0.25rem 1.5rem;
  color: #212529;
}

.btn-group,
.btn-group-vertical {
  position: relative;
  display: inline-flex;
  vertical-align: middle;
}

.btn-group > .btn,
.btn-group-vertical > .btn {
  position: relative;
  flex: 1 1 auto;
}

.btn-group > .btn:hover,
.btn-group-vertical > .btn:hover {
  z-index: 1;
}

.btn-group > .btn:focus,
.btn-group > .btn:active,
.btn-group > .btn.active,
.btn-group-vertical > .btn:focus,
.btn-group-vertical > .btn:active,
.btn-group-vertical > .btn.active {
  z-index: 1;
}

.btn-toolbar {
  display: flex;
  flex-wrap: wrap;
  justify-content: flex-start;
}

.btn-toolbar .input-group {
  width: auto;
}

.btn-group > .btn:not(:first-child),
.btn-group > .btn-group:not(:first-child) {
  margin-left: -1px;
}

.btn-group > .btn:not(:last-child):not(.dropdown-toggle),
.btn-group > .btn-group:not(:last-child) > .btn {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.btn-group > .btn:not(:first-child),
.btn-group > .btn-group:not(:first-child) > .btn {
  border-top-left-radius: 0;
  border-bottom-left-radius: 0;
}

.dropdown-toggle-split {
  padding-right: 0.5625rem;
  padding-left: 0.5625rem;
}

.dropdown-toggle-split::after,
.dropup .dropdown-toggle-split::after,
.dropright .dropdown-toggle-split::after {
  margin-left: 0;
}

.dropleft .dropdown-toggle-split::before {
  margin-right: 0;
}

.btn-sm + .dropdown-toggle-split,
.btn-group-sm > .btn + .dropdown-toggle-split {
  padding-right: 0.375rem;
  padding-left: 0.375rem;
}

.btn-lg + .dropdown-toggle-split,
.btn-group-lg > .btn + .dropdown-toggle-split {
  padding-right: 0.75rem;
  padding-left: 0.75rem;
}

.btn-group-vertical {
  flex-direction: column;
  align-items: flex-start;
  justify-content: center;
}

.btn-group-vertical > .btn,
.btn-group-vertical > .btn-group {
  width: 100%;
}

.btn-group-vertical > .btn:not(:first-child),
.btn-group-vertical > .btn-group:not(:first-child) {
  margin-top: -1px;
}

.btn-group-vertical > .btn:not(:last-child):not(.dropdown-toggle),
.btn-group-vertical > .btn-group:not(:last-child) > .btn {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}

.btn-group-vertical > .btn:not(:first-child),
.btn-group-vertical > .btn-group:not(:first-child) > .btn {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
}

.btn-group-toggle > .btn,
.btn-group-toggle > .btn-group > .btn {
  margin-bottom: 0;
}

.btn-group-toggle > .btn input[type=radio],
.btn-group-toggle > .btn input[type=checkbox],
.btn-group-toggle > .btn-group > .btn input[type=radio],
.btn-group-toggle > .btn-group > .btn input[type=checkbox] {
  position: absolute;
  clip: rect(0, 0, 0, 0);
  pointer-events: none;
}

.input-group {
  position: relative;
  display: flex;
  flex-wrap: wrap;
  align-items: stretch;
  width: 100%;
}

.input-group > .form-control,
.input-group > .form-control-plaintext,
.input-group > .custom-select,
.input-group > .custom-file {
  position: relative;
  flex: 1 1 auto;
  width: 1%;
  min-width: 0;
  margin-bottom: 0;
}

.input-group > .form-control + .form-control,
.input-group > .form-control + .custom-select,
.input-group > .form-control + .custom-file,
.input-group > .form-control-plaintext + .form-control,
.input-group > .form-control-plaintext + .custom-select,
.input-group > .form-control-plaintext + .custom-file,
.input-group > .custom-select + .form-control,
.input-group > .custom-select + .custom-select,
.input-group > .custom-select + .custom-file,
.input-group > .custom-file + .form-control,
.input-group > .custom-file + .custom-select,
.input-group > .custom-file + .custom-file {
  margin-left: -1px;
}

.input-group > .form-control:focus,
.input-group > .custom-select:focus,
.input-group > .custom-file .custom-file-input:focus ~ .custom-file-label {
  z-index: 3;
}

.input-group > .custom-file .custom-file-input:focus {
  z-index: 4;
}

.input-group > .form-control:not(:last-child),
.input-group > .custom-select:not(:last-child) {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.input-group > .form-control:not(:first-child),
.input-group > .custom-select:not(:first-child) {
  border-top-left-radius: 0;
  border-bottom-left-radius: 0;
}

.input-group > .custom-file {
  display: flex;
  align-items: center;
}

.input-group > .custom-file:not(:last-child) .custom-file-label,
.input-group > .custom-file:not(:last-child) .custom-file-label::after {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.input-group > .custom-file:not(:first-child) .custom-file-label {
  border-top-left-radius: 0;
  border-bottom-left-radius: 0;
}

.input-group-prepend,
.input-group-append {
  display: flex;
}

.input-group-prepend .btn,
.input-group-append .btn {
  position: relative;
  z-index: 2;
}

.input-group-prepend .btn:focus,
.input-group-append .btn:focus {
  z-index: 3;
}

.input-group-prepend .btn + .btn,
.input-group-prepend .btn + .input-group-text,
.input-group-prepend .input-group-text + .input-group-text,
.input-group-prepend .input-group-text + .btn,
.input-group-append .btn + .btn,
.input-group-append .btn + .input-group-text,
.input-group-append .input-group-text + .input-group-text,
.input-group-append .input-group-text + .btn {
  margin-left: -1px;
}

.input-group-prepend {
  margin-right: -1px;
}

.input-group-append {
  margin-left: -1px;
}

.input-group-text {
  display: flex;
  align-items: center;
  padding: 0.375rem 0.75rem;
  margin-bottom: 0;
  font-size: 0.9rem;
  font-weight: 400;
  line-height: 1.6;
  color: #495057;
  text-align: center;
  white-space: nowrap;
  background-color: #e9ecef;
  border: 1px solid #ced4da;
  border-radius: 0.25rem;
}

.input-group-text input[type=radio],
.input-group-text input[type=checkbox] {
  margin-top: 0;
}

.input-group-lg > .form-control:not(textarea),
.input-group-lg > .custom-select {
  height: calc(1.5em + 1rem + 2px);
}

.input-group-lg > .form-control,
.input-group-lg > .custom-select,
.input-group-lg > .input-group-prepend > .input-group-text,
.input-group-lg > .input-group-append > .input-group-text,
.input-group-lg > .input-group-prepend > .btn,
.input-group-lg > .input-group-append > .btn {
  padding: 0.5rem 1rem;
  font-size: 1.125rem;
  line-height: 1.5;
  border-radius: 0.3rem;
}

.input-group-sm > .form-control:not(textarea),
.input-group-sm > .custom-select {
  height: calc(1.5em + 0.5rem + 2px);
}

.input-group-sm > .form-control,
.input-group-sm > .custom-select,
.input-group-sm > .input-group-prepend > .input-group-text,
.input-group-sm > .input-group-append > .input-group-text,
.input-group-sm > .input-group-prepend > .btn,
.input-group-sm > .input-group-append > .btn {
  padding: 0.25rem 0.5rem;
  font-size: 0.7875rem;
  line-height: 1.5;
  border-radius: 0.2rem;
}

.input-group-lg > .custom-select,
.input-group-sm > .custom-select {
  padding-right: 1.75rem;
}

.input-group > .input-group-prepend > .btn,
.input-group > .input-group-prepend > .input-group-text,
.input-group > .input-group-append:not(:last-child) > .btn,
.input-group > .input-group-append:not(:last-child) > .input-group-text,
.input-group > .input-group-append:last-child > .btn:not(:last-child):not(.dropdown-toggle),
.input-group > .input-group-append:last-child > .input-group-text:not(:last-child) {
  border-top-right-radius: 0;
  border-bottom-right-radius: 0;
}

.input-group > .input-group-append > .btn,
.input-group > .input-group-append > .input-group-text,
.input-group > .input-group-prepend:not(:first-child) > .btn,
.input-group > .input-group-prepend:not(:first-child) > .input-group-text,
.input-group > .input-group-prepend:first-child > .btn:not(:first-child),
.input-group > .input-group-prepend:first-child > .input-group-text:not(:first-child) {
  border-top-left-radius: 0;
  border-bottom-left-radius: 0;
}

.custom-control {
  position: relative;
  z-index: 1;
  display: block;
  min-height: 1.44rem;
  padding-left: 1.5rem;
  -webkit-print-color-adjust: exact;
          color-adjust: exact;
}

.custom-control-inline {
  display: inline-flex;
  margin-right: 1rem;
}

.custom-control-input {
  position: absolute;
  left: 0;
  z-index: -1;
  width: 1rem;
  height: 1.22rem;
  opacity: 0;
}

.custom-control-input:checked ~ .custom-control-label::before {
  color: #fff;
  border-color: #3490dc;
  background-color: #3490dc;
}

.custom-control-input:focus ~ .custom-control-label::before {
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.custom-control-input:focus:not(:checked) ~ .custom-control-label::before {
  border-color: #a1cbef;
}

.custom-control-input:not(:disabled):active ~ .custom-control-label::before {
  color: #fff;
  background-color: #cce3f6;
  border-color: #cce3f6;
}

.custom-control-input[disabled] ~ .custom-control-label,
.custom-control-input:disabled ~ .custom-control-label {
  color: #6c757d;
}

.custom-control-input[disabled] ~ .custom-control-label::before,
.custom-control-input:disabled ~ .custom-control-label::before {
  background-color: #e9ecef;
}

.custom-control-label {
  position: relative;
  margin-bottom: 0;
  vertical-align: top;
}

.custom-control-label::before {
  position: absolute;
  top: 0.22rem;
  left: -1.5rem;
  display: block;
  width: 1rem;
  height: 1rem;
  pointer-events: none;
  content: "";
  background-color: #fff;
  border: #adb5bd solid 1px;
}

.custom-control-label::after {
  position: absolute;
  top: 0.22rem;
  left: -1.5rem;
  display: block;
  width: 1rem;
  height: 1rem;
  content: "";
  background: no-repeat 50%/50% 50%;
}

.custom-checkbox .custom-control-label::before {
  border-radius: 0.25rem;
}

.custom-checkbox .custom-control-input:checked ~ .custom-control-label::after {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath fill='%23fff' d='M6.564.75l-3.59 3.612-1.538-1.55L0 4.26l2.974 2.99L8 2.193z'/%3e%3c/svg%3e");
}

.custom-checkbox .custom-control-input:indeterminate ~ .custom-control-label::before {
  border-color: #3490dc;
  background-color: #3490dc;
}

.custom-checkbox .custom-control-input:indeterminate ~ .custom-control-label::after {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='4' height='4' viewBox='0 0 4 4'%3e%3cpath stroke='%23fff' d='M0 2h4'/%3e%3c/svg%3e");
}

.custom-checkbox .custom-control-input:disabled:checked ~ .custom-control-label::before {
  background-color: rgba(52, 144, 220, 0.5);
}

.custom-checkbox .custom-control-input:disabled:indeterminate ~ .custom-control-label::before {
  background-color: rgba(52, 144, 220, 0.5);
}

.custom-radio .custom-control-label::before {
  border-radius: 50%;
}

.custom-radio .custom-control-input:checked ~ .custom-control-label::after {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='12' height='12' viewBox='-4 -4 8 8'%3e%3ccircle r='3' fill='%23fff'/%3e%3c/svg%3e");
}

.custom-radio .custom-control-input:disabled:checked ~ .custom-control-label::before {
  background-color: rgba(52, 144, 220, 0.5);
}

.custom-switch {
  padding-left: 2.25rem;
}

.custom-switch .custom-control-label::before {
  left: -2.25rem;
  width: 1.75rem;
  pointer-events: all;
  border-radius: 0.5rem;
}

.custom-switch .custom-control-label::after {
  top: calc(0.22rem + 2px);
  left: calc(-2.25rem + 2px);
  width: calc(1rem - 4px);
  height: calc(1rem - 4px);
  background-color: #adb5bd;
  border-radius: 0.5rem;
  transition: transform 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

@media (prefers-reduced-motion: reduce) {
  .custom-switch .custom-control-label::after {
    transition: none;
  }
}

.custom-switch .custom-control-input:checked ~ .custom-control-label::after {
  background-color: #fff;
  transform: translateX(0.75rem);
}

.custom-switch .custom-control-input:disabled:checked ~ .custom-control-label::before {
  background-color: rgba(52, 144, 220, 0.5);
}

.custom-select {
  display: inline-block;
  width: 100%;
  height: calc(1.6em + 0.75rem + 2px);
  padding: 0.375rem 1.75rem 0.375rem 0.75rem;
  font-size: 0.9rem;
  font-weight: 400;
  line-height: 1.6;
  color: #495057;
  vertical-align: middle;
  background: #fff url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='4' height='5' viewBox='0 0 4 5'%3e%3cpath fill='%23343a40' d='M2 0L0 2h4zm0 5L0 3h4z'/%3e%3c/svg%3e") no-repeat right 0.75rem center/8px 10px;
  border: 1px solid #ced4da;
  border-radius: 0.25rem;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.custom-select:focus {
  border-color: #a1cbef;
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.custom-select:focus::-ms-value {
  color: #495057;
  background-color: #fff;
}

.custom-select[multiple],
.custom-select[size]:not([size="1"]) {
  height: auto;
  padding-right: 0.75rem;
  background-image: none;
}

.custom-select:disabled {
  color: #6c757d;
  background-color: #e9ecef;
}

.custom-select::-ms-expand {
  display: none;
}

.custom-select:-moz-focusring {
  color: transparent;
  text-shadow: 0 0 0 #495057;
}

.custom-select-sm {
  height: calc(1.5em + 0.5rem + 2px);
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
  padding-left: 0.5rem;
  font-size: 0.7875rem;
}

.custom-select-lg {
  height: calc(1.5em + 1rem + 2px);
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  padding-left: 1rem;
  font-size: 1.125rem;
}

.custom-file {
  position: relative;
  display: inline-block;
  width: 100%;
  height: calc(1.6em + 0.75rem + 2px);
  margin-bottom: 0;
}

.custom-file-input {
  position: relative;
  z-index: 2;
  width: 100%;
  height: calc(1.6em + 0.75rem + 2px);
  margin: 0;
  opacity: 0;
}

.custom-file-input:focus ~ .custom-file-label {
  border-color: #a1cbef;
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.custom-file-input[disabled] ~ .custom-file-label,
.custom-file-input:disabled ~ .custom-file-label {
  background-color: #e9ecef;
}

.custom-file-input:lang(en) ~ .custom-file-label::after {
  content: "Browse";
}

.custom-file-input ~ .custom-file-label[data-browse]::after {
  content: attr(data-browse);
}

.custom-file-label {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  z-index: 1;
  height: calc(1.6em + 0.75rem + 2px);
  padding: 0.375rem 0.75rem;
  font-weight: 400;
  line-height: 1.6;
  color: #495057;
  background-color: #fff;
  border: 1px solid #ced4da;
  border-radius: 0.25rem;
}

.custom-file-label::after {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  z-index: 3;
  display: block;
  height: calc(1.6em + 0.75rem);
  padding: 0.375rem 0.75rem;
  line-height: 1.6;
  color: #495057;
  content: "Browse";
  background-color: #e9ecef;
  border-left: inherit;
  border-radius: 0 0.25rem 0.25rem 0;
}

.custom-range {
  width: 100%;
  height: 1.4rem;
  padding: 0;
  background-color: transparent;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.custom-range:focus {
  outline: none;
}

.custom-range:focus::-webkit-slider-thumb {
  box-shadow: 0 0 0 1px #f8fafc, 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.custom-range:focus::-moz-range-thumb {
  box-shadow: 0 0 0 1px #f8fafc, 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.custom-range:focus::-ms-thumb {
  box-shadow: 0 0 0 1px #f8fafc, 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.custom-range::-moz-focus-outer {
  border: 0;
}

.custom-range::-webkit-slider-thumb {
  width: 1rem;
  height: 1rem;
  margin-top: -0.25rem;
  background-color: #3490dc;
  border: 0;
  border-radius: 1rem;
  -webkit-transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  -webkit-appearance: none;
          appearance: none;
}

@media (prefers-reduced-motion: reduce) {
  .custom-range::-webkit-slider-thumb {
    -webkit-transition: none;
    transition: none;
  }
}

.custom-range::-webkit-slider-thumb:active {
  background-color: #cce3f6;
}

.custom-range::-webkit-slider-runnable-track {
  width: 100%;
  height: 0.5rem;
  color: transparent;
  cursor: pointer;
  background-color: #dee2e6;
  border-color: transparent;
  border-radius: 1rem;
}

.custom-range::-moz-range-thumb {
  width: 1rem;
  height: 1rem;
  background-color: #3490dc;
  border: 0;
  border-radius: 1rem;
  -moz-transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  -moz-appearance: none;
       appearance: none;
}

@media (prefers-reduced-motion: reduce) {
  .custom-range::-moz-range-thumb {
    -moz-transition: none;
    transition: none;
  }
}

.custom-range::-moz-range-thumb:active {
  background-color: #cce3f6;
}

.custom-range::-moz-range-track {
  width: 100%;
  height: 0.5rem;
  color: transparent;
  cursor: pointer;
  background-color: #dee2e6;
  border-color: transparent;
  border-radius: 1rem;
}

.custom-range::-ms-thumb {
  width: 1rem;
  height: 1rem;
  margin-top: 0;
  margin-right: 0.2rem;
  margin-left: 0.2rem;
  background-color: #3490dc;
  border: 0;
  border-radius: 1rem;
  -ms-transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
  appearance: none;
}

@media (prefers-reduced-motion: reduce) {
  .custom-range::-ms-thumb {
    -ms-transition: none;
    transition: none;
  }
}

.custom-range::-ms-thumb:active {
  background-color: #cce3f6;
}

.custom-range::-ms-track {
  width: 100%;
  height: 0.5rem;
  color: transparent;
  cursor: pointer;
  background-color: transparent;
  border-color: transparent;
  border-width: 0.5rem;
}

.custom-range::-ms-fill-lower {
  background-color: #dee2e6;
  border-radius: 1rem;
}

.custom-range::-ms-fill-upper {
  margin-right: 15px;
  background-color: #dee2e6;
  border-radius: 1rem;
}

.custom-range:disabled::-webkit-slider-thumb {
  background-color: #adb5bd;
}

.custom-range:disabled::-webkit-slider-runnable-track {
  cursor: default;
}

.custom-range:disabled::-moz-range-thumb {
  background-color: #adb5bd;
}

.custom-range:disabled::-moz-range-track {
  cursor: default;
}

.custom-range:disabled::-ms-thumb {
  background-color: #adb5bd;
}

.custom-control-label::before,
.custom-file-label,
.custom-select {
  transition: background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

@media (prefers-reduced-motion: reduce) {
  .custom-control-label::before,
  .custom-file-label,
  .custom-select {
    transition: none;
  }
}

.nav {
  display: flex;
  flex-wrap: wrap;
  padding-left: 0;
  margin-bottom: 0;
  list-style: none;
}

.nav-link {
  display: block;
  padding: 0.5rem 1rem;
}

.nav-link:hover,
.nav-link:focus {
  text-decoration: none;
}

.nav-link.disabled {
  color: #6c757d;
  pointer-events: none;
  cursor: default;
}

.nav-tabs {
  border-bottom: 1px solid #dee2e6;
}

.nav-tabs .nav-item {
  margin-bottom: -1px;
}

.nav-tabs .nav-link {
  border: 1px solid transparent;
  border-top-left-radius: 0.25rem;
  border-top-right-radius: 0.25rem;
}

.nav-tabs .nav-link:hover,
.nav-tabs .nav-link:focus {
  border-color: #e9ecef #e9ecef #dee2e6;
}

.nav-tabs .nav-link.disabled {
  color: #6c757d;
  background-color: transparent;
  border-color: transparent;
}

.nav-tabs .nav-link.active,
.nav-tabs .nav-item.show .nav-link {
  color: #495057;
  background-color: #f8fafc;
  border-color: #dee2e6 #dee2e6 #f8fafc;
}

.nav-tabs .dropdown-menu {
  margin-top: -1px;
  border-top-left-radius: 0;
  border-top-right-radius: 0;
}

.nav-pills .nav-link {
  border-radius: 0.25rem;
}

.nav-pills .nav-link.active,
.nav-pills .show > .nav-link {
  color: #fff;
  background-color: #3490dc;
}

.nav-fill > .nav-link,
.nav-fill .nav-item {
  flex: 1 1 auto;
  text-align: center;
}

.nav-justified > .nav-link,
.nav-justified .nav-item {
  flex-basis: 0;
  flex-grow: 1;
  text-align: center;
}

.tab-content > .tab-pane {
  display: none;
}

.tab-content > .active {
  display: block;
}

.navbar {
  position: relative;
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: space-between;
  padding: 0.5rem 1rem;
}

.navbar .container,
.navbar .container-fluid,
.navbar .container-sm,
.navbar .container-md,
.navbar .container-lg,
.navbar .container-xl {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: space-between;
}

.navbar-brand {
  display: inline-block;
  padding-top: 0.32rem;
  padding-bottom: 0.32rem;
  margin-right: 1rem;
  font-size: 1.125rem;
  line-height: inherit;
  white-space: nowrap;
}

.navbar-brand:hover,
.navbar-brand:focus {
  text-decoration: none;
}

.navbar-nav {
  display: flex;
  flex-direction: column;
  padding-left: 0;
  margin-bottom: 0;
  list-style: none;
}

.navbar-nav .nav-link {
  padding-right: 0;
  padding-left: 0;
}

.navbar-nav .dropdown-menu {
  position: static;
  float: none;
}

.navbar-text {
  display: inline-block;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.navbar-collapse {
  flex-basis: 100%;
  flex-grow: 1;
  align-items: center;
}

.navbar-toggler {
  padding: 0.25rem 0.75rem;
  font-size: 1.125rem;
  line-height: 1;
  background-color: transparent;
  border: 1px solid transparent;
  border-radius: 0.25rem;
}

.navbar-toggler:hover,
.navbar-toggler:focus {
  text-decoration: none;
}

.navbar-toggler-icon {
  display: inline-block;
  width: 1.5em;
  height: 1.5em;
  vertical-align: middle;
  content: "";
  background: no-repeat center center;
  background-size: 100% 100%;
}

@media (max-width: 575.98px) {
  .navbar-expand-sm > .container,
  .navbar-expand-sm > .container-fluid,
  .navbar-expand-sm > .container-sm,
  .navbar-expand-sm > .container-md,
  .navbar-expand-sm > .container-lg,
  .navbar-expand-sm > .container-xl {
    padding-right: 0;
    padding-left: 0;
  }
}

@media (min-width: 576px) {
  .navbar-expand-sm {
    flex-flow: row nowrap;
    justify-content: flex-start;
  }

  .navbar-expand-sm .navbar-nav {
    flex-direction: row;
  }

  .navbar-expand-sm .navbar-nav .dropdown-menu {
    position: absolute;
  }

  .navbar-expand-sm .navbar-nav .nav-link {
    padding-right: 0.5rem;
    padding-left: 0.5rem;
  }

  .navbar-expand-sm > .container,
  .navbar-expand-sm > .container-fluid,
  .navbar-expand-sm > .container-sm,
  .navbar-expand-sm > .container-md,
  .navbar-expand-sm > .container-lg,
  .navbar-expand-sm > .container-xl {
    flex-wrap: nowrap;
  }

  .navbar-expand-sm .navbar-collapse {
    display: flex !important;
    flex-basis: auto;
  }

  .navbar-expand-sm .navbar-toggler {
    display: none;
  }
}

@media (max-width: 767.98px) {
  .navbar-expand-md > .container,
  .navbar-expand-md > .container-fluid,
  .navbar-expand-md > .container-sm,
  .navbar-expand-md > .container-md,
  .navbar-expand-md > .container-lg,
  .navbar-expand-md > .container-xl {
    padding-right: 0;
    padding-left: 0;
  }
}

@media (min-width: 768px) {
  .navbar-expand-md {
    flex-flow: row nowrap;
    justify-content: flex-start;
  }

  .navbar-expand-md .navbar-nav {
    flex-direction: row;
  }

  .navbar-expand-md .navbar-nav .dropdown-menu {
    position: absolute;
  }

  .navbar-expand-md .navbar-nav .nav-link {
    padding-right: 0.5rem;
    padding-left: 0.5rem;
  }

  .navbar-expand-md > .container,
  .navbar-expand-md > .container-fluid,
  .navbar-expand-md > .container-sm,
  .navbar-expand-md > .container-md,
  .navbar-expand-md > .container-lg,
  .navbar-expand-md > .container-xl {
    flex-wrap: nowrap;
  }

  .navbar-expand-md .navbar-collapse {
    display: flex !important;
    flex-basis: auto;
  }

  .navbar-expand-md .navbar-toggler {
    display: none;
  }
}

@media (max-width: 991.98px) {
  .navbar-expand-lg > .container,
  .navbar-expand-lg > .container-fluid,
  .navbar-expand-lg > .container-sm,
  .navbar-expand-lg > .container-md,
  .navbar-expand-lg > .container-lg,
  .navbar-expand-lg > .container-xl {
    padding-right: 0;
    padding-left: 0;
  }
}

@media (min-width: 992px) {
  .navbar-expand-lg {
    flex-flow: row nowrap;
    justify-content: flex-start;
  }

  .navbar-expand-lg .navbar-nav {
    flex-direction: row;
  }

  .navbar-expand-lg .navbar-nav .dropdown-menu {
    position: absolute;
  }

  .navbar-expand-lg .navbar-nav .nav-link {
    padding-right: 0.5rem;
    padding-left: 0.5rem;
  }

  .navbar-expand-lg > .container,
  .navbar-expand-lg > .container-fluid,
  .navbar-expand-lg > .container-sm,
  .navbar-expand-lg > .container-md,
  .navbar-expand-lg > .container-lg,
  .navbar-expand-lg > .container-xl {
    flex-wrap: nowrap;
  }

  .navbar-expand-lg .navbar-collapse {
    display: flex !important;
    flex-basis: auto;
  }

  .navbar-expand-lg .navbar-toggler {
    display: none;
  }
}

@media (max-width: 1199.98px) {
  .navbar-expand-xl > .container,
  .navbar-expand-xl > .container-fluid,
  .navbar-expand-xl > .container-sm,
  .navbar-expand-xl > .container-md,
  .navbar-expand-xl > .container-lg,
  .navbar-expand-xl > .container-xl {
    padding-right: 0;
    padding-left: 0;
  }
}

@media (min-width: 1200px) {
  .navbar-expand-xl {
    flex-flow: row nowrap;
    justify-content: flex-start;
  }

  .navbar-expand-xl .navbar-nav {
    flex-direction: row;
  }

  .navbar-expand-xl .navbar-nav .dropdown-menu {
    position: absolute;
  }

  .navbar-expand-xl .navbar-nav .nav-link {
    padding-right: 0.5rem;
    padding-left: 0.5rem;
  }

  .navbar-expand-xl > .container,
  .navbar-expand-xl > .container-fluid,
  .navbar-expand-xl > .container-sm,
  .navbar-expand-xl > .container-md,
  .navbar-expand-xl > .container-lg,
  .navbar-expand-xl > .container-xl {
    flex-wrap: nowrap;
  }

  .navbar-expand-xl .navbar-collapse {
    display: flex !important;
    flex-basis: auto;
  }

  .navbar-expand-xl .navbar-toggler {
    display: none;
  }
}

.navbar-expand {
  flex-flow: row nowrap;
  justify-content: flex-start;
}

.navbar-expand > .container,
.navbar-expand > .container-fluid,
.navbar-expand > .container-sm,
.navbar-expand > .container-md,
.navbar-expand > .container-lg,
.navbar-expand > .container-xl {
  padding-right: 0;
  padding-left: 0;
}

.navbar-expand .navbar-nav {
  flex-direction: row;
}

.navbar-expand .navbar-nav .dropdown-menu {
  position: absolute;
}

.navbar-expand .navbar-nav .nav-link {
  padding-right: 0.5rem;
  padding-left: 0.5rem;
}

.navbar-expand > .container,
.navbar-expand > .container-fluid,
.navbar-expand > .container-sm,
.navbar-expand > .container-md,
.navbar-expand > .container-lg,
.navbar-expand > .container-xl {
  flex-wrap: nowrap;
}

.navbar-expand .navbar-collapse {
  display: flex !important;
  flex-basis: auto;
}

.navbar-expand .navbar-toggler {
  display: none;
}

.navbar-light .navbar-brand {
  color: rgba(0, 0, 0, 0.9);
}

.navbar-light .navbar-brand:hover,
.navbar-light .navbar-brand:focus {
  color: rgba(0, 0, 0, 0.9);
}

.navbar-light .navbar-nav .nav-link {
  color: rgba(0, 0, 0, 0.5);
}

.navbar-light .navbar-nav .nav-link:hover,
.navbar-light .navbar-nav .nav-link:focus {
  color: rgba(0, 0, 0, 0.7);
}

.navbar-light .navbar-nav .nav-link.disabled {
  color: rgba(0, 0, 0, 0.3);
}

.navbar-light .navbar-nav .show > .nav-link,
.navbar-light .navbar-nav .active > .nav-link,
.navbar-light .navbar-nav .nav-link.show,
.navbar-light .navbar-nav .nav-link.active {
  color: rgba(0, 0, 0, 0.9);
}

.navbar-light .navbar-toggler {
  color: rgba(0, 0, 0, 0.5);
  border-color: rgba(0, 0, 0, 0.1);
}

.navbar-light .navbar-toggler-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='30' height='30' viewBox='0 0 30 30'%3e%3cpath stroke='rgba%280, 0, 0, 0.5%29' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/%3e%3c/svg%3e");
}

.navbar-light .navbar-text {
  color: rgba(0, 0, 0, 0.5);
}

.navbar-light .navbar-text a {
  color: rgba(0, 0, 0, 0.9);
}

.navbar-light .navbar-text a:hover,
.navbar-light .navbar-text a:focus {
  color: rgba(0, 0, 0, 0.9);
}

.navbar-dark .navbar-brand {
  color: #fff;
}

.navbar-dark .navbar-brand:hover,
.navbar-dark .navbar-brand:focus {
  color: #fff;
}

.navbar-dark .navbar-nav .nav-link {
  color: rgba(255, 255, 255, 0.5);
}

.navbar-dark .navbar-nav .nav-link:hover,
.navbar-dark .navbar-nav .nav-link:focus {
  color: rgba(255, 255, 255, 0.75);
}

.navbar-dark .navbar-nav .nav-link.disabled {
  color: rgba(255, 255, 255, 0.25);
}

.navbar-dark .navbar-nav .show > .nav-link,
.navbar-dark .navbar-nav .active > .nav-link,
.navbar-dark .navbar-nav .nav-link.show,
.navbar-dark .navbar-nav .nav-link.active {
  color: #fff;
}

.navbar-dark .navbar-toggler {
  color: rgba(255, 255, 255, 0.5);
  border-color: rgba(255, 255, 255, 0.1);
}

.navbar-dark .navbar-toggler-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' width='30' height='30' viewBox='0 0 30 30'%3e%3cpath stroke='rgba%28255, 255, 255, 0.5%29' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/%3e%3c/svg%3e");
}

.navbar-dark .navbar-text {
  color: rgba(255, 255, 255, 0.5);
}

.navbar-dark .navbar-text a {
  color: #fff;
}

.navbar-dark .navbar-text a:hover,
.navbar-dark .navbar-text a:focus {
  color: #fff;
}

.card {
  position: relative;
  display: flex;
  flex-direction: column;
  min-width: 0;
  word-wrap: break-word;
  background-color: #fff;
  background-clip: border-box;
  border: 1px solid rgba(0, 0, 0, 0.125);
  border-radius: 0.25rem;
}

.card > hr {
  margin-right: 0;
  margin-left: 0;
}

.card > .list-group {
  border-top: inherit;
  border-bottom: inherit;
}

.card > .list-group:first-child {
  border-top-width: 0;
  border-top-left-radius: calc(0.25rem - 1px);
  border-top-right-radius: calc(0.25rem - 1px);
}

.card > .list-group:last-child {
  border-bottom-width: 0;
  border-bottom-right-radius: calc(0.25rem - 1px);
  border-bottom-left-radius: calc(0.25rem - 1px);
}

.card > .card-header + .list-group,
.card > .list-group + .card-footer {
  border-top: 0;
}

.card-body {
  flex: 1 1 auto;
  min-height: 1px;
  padding: 1.25rem;
}

.card-title {
  margin-bottom: 0.75rem;
}

.card-subtitle {
  margin-top: -0.375rem;
  margin-bottom: 0;
}

.card-text:last-child {
  margin-bottom: 0;
}

.card-link:hover {
  text-decoration: none;
}

.card-link + .card-link {
  margin-left: 1.25rem;
}

.card-header {
  padding: 0.75rem 1.25rem;
  margin-bottom: 0;
  background-color: rgba(0, 0, 0, 0.03);
  border-bottom: 1px solid rgba(0, 0, 0, 0.125);
}

.card-header:first-child {
  border-radius: calc(0.25rem - 1px) calc(0.25rem - 1px) 0 0;
}

.card-footer {
  padding: 0.75rem 1.25rem;
  background-color: rgba(0, 0, 0, 0.03);
  border-top: 1px solid rgba(0, 0, 0, 0.125);
}

.card-footer:last-child {
  border-radius: 0 0 calc(0.25rem - 1px) calc(0.25rem - 1px);
}

.card-header-tabs {
  margin-right: -0.625rem;
  margin-bottom: -0.75rem;
  margin-left: -0.625rem;
  border-bottom: 0;
}

.card-header-pills {
  margin-right: -0.625rem;
  margin-left: -0.625rem;
}

.card-img-overlay {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  padding: 1.25rem;
  border-radius: calc(0.25rem - 1px);
}

.card-img,
.card-img-top,
.card-img-bottom {
  flex-shrink: 0;
  width: 100%;
}

.card-img,
.card-img-top {
  border-top-left-radius: calc(0.25rem - 1px);
  border-top-right-radius: calc(0.25rem - 1px);
}

.card-img,
.card-img-bottom {
  border-bottom-right-radius: calc(0.25rem - 1px);
  border-bottom-left-radius: calc(0.25rem - 1px);
}

.card-deck .card {
  margin-bottom: 15px;
}

@media (min-width: 576px) {
  .card-deck {
    display: flex;
    flex-flow: row wrap;
    margin-right: -15px;
    margin-left: -15px;
  }

  .card-deck .card {
    flex: 1 0 0%;
    margin-right: 15px;
    margin-bottom: 0;
    margin-left: 15px;
  }
}

.card-group > .card {
  margin-bottom: 15px;
}

@media (min-width: 576px) {
  .card-group {
    display: flex;
    flex-flow: row wrap;
  }

  .card-group > .card {
    flex: 1 0 0%;
    margin-bottom: 0;
  }

  .card-group > .card + .card {
    margin-left: 0;
    border-left: 0;
  }

  .card-group > .card:not(:last-child) {
    border-top-right-radius: 0;
    border-bottom-right-radius: 0;
  }

  .card-group > .card:not(:last-child) .card-img-top,
  .card-group > .card:not(:last-child) .card-header {
    border-top-right-radius: 0;
  }

  .card-group > .card:not(:last-child) .card-img-bottom,
  .card-group > .card:not(:last-child) .card-footer {
    border-bottom-right-radius: 0;
  }

  .card-group > .card:not(:first-child) {
    border-top-left-radius: 0;
    border-bottom-left-radius: 0;
  }

  .card-group > .card:not(:first-child) .card-img-top,
  .card-group > .card:not(:first-child) .card-header {
    border-top-left-radius: 0;
  }

  .card-group > .card:not(:first-child) .card-img-bottom,
  .card-group > .card:not(:first-child) .card-footer {
    border-bottom-left-radius: 0;
  }
}

.card-columns .card {
  margin-bottom: 0.75rem;
}

@media (min-width: 576px) {
  .card-columns {
    -moz-column-count: 3;
         column-count: 3;
    -moz-column-gap: 1.25rem;
         column-gap: 1.25rem;
    orphans: 1;
    widows: 1;
  }

  .card-columns .card {
    display: inline-block;
    width: 100%;
  }
}

.accordion {
  overflow-anchor: none;
}

.accordion > .card {
  overflow: hidden;
}

.accordion > .card:not(:last-of-type) {
  border-bottom: 0;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}

.accordion > .card:not(:first-of-type) {
  border-top-left-radius: 0;
  border-top-right-radius: 0;
}

.accordion > .card > .card-header {
  border-radius: 0;
  margin-bottom: -1px;
}

.breadcrumb {
  display: flex;
  flex-wrap: wrap;
  padding: 0.75rem 1rem;
  margin-bottom: 1rem;
  list-style: none;
  background-color: #e9ecef;
  border-radius: 0.25rem;
}

.breadcrumb-item {
  display: flex;
}

.breadcrumb-item + .breadcrumb-item {
  padding-left: 0.5rem;
}

.breadcrumb-item + .breadcrumb-item::before {
  display: inline-block;
  padding-right: 0.5rem;
  color: #6c757d;
  content: "/";
}

.breadcrumb-item + .breadcrumb-item:hover::before {
  text-decoration: underline;
}

.breadcrumb-item + .breadcrumb-item:hover::before {
  text-decoration: none;
}

.breadcrumb-item.active {
  color: #6c757d;
}

.pagination {
  display: flex;
  padding-left: 0;
  list-style: none;
  border-radius: 0.25rem;
}

.page-link {
  position: relative;
  display: block;
  padding: 0.5rem 0.75rem;
  margin-left: -1px;
  line-height: 1.25;
  color: #3490dc;
  background-color: #fff;
  border: 1px solid #dee2e6;
}

.page-link:hover {
  z-index: 2;
  color: #1d68a7;
  text-decoration: none;
  background-color: #e9ecef;
  border-color: #dee2e6;
}

.page-link:focus {
  z-index: 3;
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.25);
}

.page-item:first-child .page-link {
  margin-left: 0;
  border-top-left-radius: 0.25rem;
  border-bottom-left-radius: 0.25rem;
}

.page-item:last-child .page-link {
  border-top-right-radius: 0.25rem;
  border-bottom-right-radius: 0.25rem;
}

.page-item.active .page-link {
  z-index: 3;
  color: #fff;
  background-color: #3490dc;
  border-color: #3490dc;
}

.page-item.disabled .page-link {
  color: #6c757d;
  pointer-events: none;
  cursor: auto;
  background-color: #fff;
  border-color: #dee2e6;
}

.pagination-lg .page-link {
  padding: 0.75rem 1.5rem;
  font-size: 1.125rem;
  line-height: 1.5;
}

.pagination-lg .page-item:first-child .page-link {
  border-top-left-radius: 0.3rem;
  border-bottom-left-radius: 0.3rem;
}

.pagination-lg .page-item:last-child .page-link {
  border-top-right-radius: 0.3rem;
  border-bottom-right-radius: 0.3rem;
}

.pagination-sm .page-link {
  padding: 0.25rem 0.5rem;
  font-size: 0.7875rem;
  line-height: 1.5;
}

.pagination-sm .page-item:first-child .page-link {
  border-top-left-radius: 0.2rem;
  border-bottom-left-radius: 0.2rem;
}

.pagination-sm .page-item:last-child .page-link {
  border-top-right-radius: 0.2rem;
  border-bottom-right-radius: 0.2rem;
}

.badge {
  display: inline-block;
  padding: 0.25em 0.4em;
  font-size: 75%;
  font-weight: 700;
  line-height: 1;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: 0.25rem;
  transition: color 0.15s ease-in-out, background-color 0.15s ease-in-out, border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
}

@media (prefers-reduced-motion: reduce) {
  .badge {
    transition: none;
  }
}

a.badge:hover,
a.badge:focus {
  text-decoration: none;
}

.badge:empty {
  display: none;
}

.btn .badge {
  position: relative;
  top: -1px;
}

.badge-pill {
  padding-right: 0.6em;
  padding-left: 0.6em;
  border-radius: 10rem;
}

.badge-primary {
  color: #fff;
  background-color: #3490dc;
}

a.badge-primary:hover,
a.badge-primary:focus {
  color: #fff;
  background-color: #2176bd;
}

a.badge-primary:focus,
a.badge-primary.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(52, 144, 220, 0.5);
}

.badge-secondary {
  color: #fff;
  background-color: #6c757d;
}

a.badge-secondary:hover,
a.badge-secondary:focus {
  color: #fff;
  background-color: #545b62;
}

a.badge-secondary:focus,
a.badge-secondary.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(108, 117, 125, 0.5);
}

.badge-success {
  color: #fff;
  background-color: #38c172;
}

a.badge-success:hover,
a.badge-success:focus {
  color: #fff;
  background-color: #2d995b;
}

a.badge-success:focus,
a.badge-success.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(56, 193, 114, 0.5);
}

.badge-info {
  color: #212529;
  background-color: #6cb2eb;
}

a.badge-info:hover,
a.badge-info:focus {
  color: #212529;
  background-color: #3f9ae5;
}

a.badge-info:focus,
a.badge-info.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(108, 178, 235, 0.5);
}

.badge-warning {
  color: #212529;
  background-color: #ffed4a;
}

a.badge-warning:hover,
a.badge-warning:focus {
  color: #212529;
  background-color: #ffe817;
}

a.badge-warning:focus,
a.badge-warning.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(255, 237, 74, 0.5);
}

.badge-danger {
  color: #fff;
  background-color: #e3342f;
}

a.badge-danger:hover,
a.badge-danger:focus {
  color: #fff;
  background-color: #c51f1a;
}

a.badge-danger:focus,
a.badge-danger.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(227, 52, 47, 0.5);
}

.badge-light {
  color: #212529;
  background-color: #f8f9fa;
}

a.badge-light:hover,
a.badge-light:focus {
  color: #212529;
  background-color: #dae0e5;
}

a.badge-light:focus,
a.badge-light.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(248, 249, 250, 0.5);
}

.badge-dark {
  color: #fff;
  background-color: #343a40;
}

a.badge-dark:hover,
a.badge-dark:focus {
  color: #fff;
  background-color: #1d2124;
}

a.badge-dark:focus,
a.badge-dark.focus {
  outline: 0;
  box-shadow: 0 0 0 0.2rem rgba(52, 58, 64, 0.5);
}

.jumbotron {
  padding: 2rem 1rem;
  margin-bottom: 2rem;
  background-color: #e9ecef;
  border-radius: 0.3rem;
}

@media (min-width: 576px) {
  .jumbotron {
    padding: 4rem 2rem;
  }
}

.jumbotron-fluid {
  padding-right: 0;
  padding-left: 0;
  border-radius: 0;
}

.alert {
  position: relative;
  padding: 0.75rem 1.25rem;
  margin-bottom: 1rem;
  border: 1px solid transparent;
  border-radius: 0.25rem;
}

.alert-heading {
  color: inherit;
}

.alert-link {
  font-weight: 700;
}

.alert-dismissible {
  padding-right: 3.85rem;
}

.alert-dismissible .close {
  position: absolute;
  top: 0;
  right: 0;
  z-index: 2;
  padding: 0.75rem 1.25rem;
  color: inherit;
}

.alert-primary {
  color: #1b4b72;
  background-color: #d6e9f8;
  border-color: #c6e0f5;
}

.alert-primary hr {
  border-top-color: #b0d4f1;
}

.alert-primary .alert-link {
  color: #113049;
}

.alert-secondary {
  color: #383d41;
  background-color: #e2e3e5;
  border-color: #d6d8db;
}

.alert-secondary hr {
  border-top-color: #c8cbcf;
}

.alert-secondary .alert-link {
  color: #202326;
}

.alert-success {
  color: #1d643b;
  background-color: #d7f3e3;
  border-color: #c7eed8;
}

.alert-success hr {
  border-top-color: #b3e8ca;
}

.alert-success .alert-link {
  color: #123c24;
}

.alert-info {
  color: #385d7a;
  background-color: #e2f0fb;
  border-color: #d6e9f9;
}

.alert-info hr {
  border-top-color: #c0ddf6;
}

.alert-info .alert-link {
  color: #284257;
}

.alert-warning {
  color: #857b26;
  background-color: #fffbdb;
  border-color: #fffacc;
}

.alert-warning hr {
  border-top-color: #fff8b3;
}

.alert-warning .alert-link {
  color: #5d561b;
}

.alert-danger {
  color: #761b18;
  background-color: #f9d6d5;
  border-color: #f7c6c5;
}

.alert-danger hr {
  border-top-color: #f4b0af;
}

.alert-danger .alert-link {
  color: #4c110f;
}

.alert-light {
  color: #818182;
  background-color: #fefefe;
  border-color: #fdfdfe;
}

.alert-light hr {
  border-top-color: #ececf6;
}

.alert-light .alert-link {
  color: #686868;
}

.alert-dark {
  color: #1b1e21;
  background-color: #d6d8d9;
  border-color: #c6c8ca;
}

.alert-dark hr {
  border-top-color: #b9bbbe;
}

.alert-dark .alert-link {
  color: #040505;
}

@-webkit-keyframes progress-bar-stripes {
  from {
    background-position: 1rem 0;
  }

  to {
    background-position: 0 0;
  }
}

@keyframes progress-bar-stripes {
  from {
    background-position: 1rem 0;
  }

  to {
    background-position: 0 0;
  }
}

.progress {
  display: flex;
  height: 1rem;
  overflow: hidden;
  line-height: 0;
  font-size: 0.675rem;
  background-color: #e9ecef;
  border-radius: 0.25rem;
}

.progress-bar {
  display: flex;
  flex-direction: column;
  justify-content: center;
  overflow: hidden;
  color: #fff;
  text-align: center;
  white-space: nowrap;
  background-color: #3490dc;
  transition: width 0.6s ease;
}

@media (prefers-reduced-motion: reduce) {
  .progress-bar {
    transition: none;
  }
}

.progress-bar-striped {
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-size: 1rem 1rem;
}

.progress-bar-animated {
  -webkit-animation: progress-bar-stripes 1s linear infinite;
          animation: progress-bar-stripes 1s linear infinite;
}

@media (prefers-reduced-motion: reduce) {
  .progress-bar-animated {
    -webkit-animation: none;
            animation: none;
  }
}

.media {
  display: flex;
  align-items: flex-start;
}

.media-body {
  flex: 1;
}

.list-group {
  display: flex;
  flex-direction: column;
  padding-left: 0;
  margin-bottom: 0;
  border-radius: 0.25rem;
}

.list-group-item-action {
  width: 100%;
  color: #495057;
  text-align: inherit;
}

.list-group-item-action:hover,
.list-group-item-action:focus {
  z-index: 1;
  color: #495057;
  text-decoration: none;
  background-color: #f8f9fa;
}

.list-group-item-action:active {
  color: #212529;
  background-color: #e9ecef;
}

.list-group-item {
  position: relative;
  display: block;
  padding: 0.75rem 1.25rem;
  background-color: #fff;
  border: 1px solid rgba(0, 0, 0, 0.125);
}

.list-group-item:first-child {
  border-top-left-radius: inherit;
  border-top-right-radius: inherit;
}

.list-group-item:last-child {
  border-bottom-right-radius: inherit;
  border-bottom-left-radius: inherit;
}

.list-group-item.disabled,
.list-group-item:disabled {
  color: #6c757d;
  pointer-events: none;
  background-color: #fff;
}

.list-group-item.active {
  z-index: 2;
  color: #fff;
  background-color: #3490dc;
  border-color: #3490dc;
}

.list-group-item + .list-group-item {
  border-top-width: 0;
}

.list-group-item + .list-group-item.active {
  margin-top: -1px;
  border-top-width: 1px;
}

.list-group-horizontal {
  flex-direction: row;
}

.list-group-horizontal > .list-group-item:first-child {
  border-bottom-left-radius: 0.25rem;
  border-top-right-radius: 0;
}

.list-group-horizontal > .list-group-item:last-child {
  border-top-right-radius: 0.25rem;
  border-bottom-left-radius: 0;
}

.list-group-horizontal > .list-group-item.active {
  margin-top: 0;
}

.list-group-horizontal > .list-group-item + .list-group-item {
  border-top-width: 1px;
  border-left-width: 0;
}

.list-group-horizontal > .list-group-item + .list-group-item.active {
  margin-left: -1px;
  border-left-width: 1px;
}

@media (min-width: 576px) {
  .list-group-horizontal-sm {
    flex-direction: row;
  }

  .list-group-horizontal-sm > .list-group-item:first-child {
    border-bottom-left-radius: 0.25rem;
    border-top-right-radius: 0;
  }

  .list-group-horizontal-sm > .list-group-item:last-child {
    border-top-right-radius: 0.25rem;
    border-bottom-left-radius: 0;
  }

  .list-group-horizontal-sm > .list-group-item.active {
    margin-top: 0;
  }

  .list-group-horizontal-sm > .list-group-item + .list-group-item {
    border-top-width: 1px;
    border-left-width: 0;
  }

  .list-group-horizontal-sm > .list-group-item + .list-group-item.active {
    margin-left: -1px;
    border-left-width: 1px;
  }
}

@media (min-width: 768px) {
  .list-group-horizontal-md {
    flex-direction: row;
  }

  .list-group-horizontal-md > .list-group-item:first-child {
    border-bottom-left-radius: 0.25rem;
    border-top-right-radius: 0;
  }

  .list-group-horizontal-md > .list-group-item:last-child {
    border-top-right-radius: 0.25rem;
    border-bottom-left-radius: 0;
  }

  .list-group-horizontal-md > .list-group-item.active {
    margin-top: 0;
  }

  .list-group-horizontal-md > .list-group-item + .list-group-item {
    border-top-width: 1px;
    border-left-width: 0;
  }

  .list-group-horizontal-md > .list-group-item + .list-group-item.active {
    margin-left: -1px;
    border-left-width: 1px;
  }
}

@media (min-width: 992px) {
  .list-group-horizontal-lg {
    flex-direction: row;
  }

  .list-group-horizontal-lg > .list-group-item:first-child {
    border-bottom-left-radius: 0.25rem;
    border-top-right-radius: 0;
  }

  .list-group-horizontal-lg > .list-group-item:last-child {
    border-top-right-radius: 0.25rem;
    border-bottom-left-radius: 0;
  }

  .list-group-horizontal-lg > .list-group-item.active {
    margin-top: 0;
  }

  .list-group-horizontal-lg > .list-group-item + .list-group-item {
    border-top-width: 1px;
    border-left-width: 0;
  }

  .list-group-horizontal-lg > .list-group-item + .list-group-item.active {
    margin-left: -1px;
    border-left-width: 1px;
  }
}

@media (min-width: 1200px) {
  .list-group-horizontal-xl {
    flex-direction: row;
  }

  .list-group-horizontal-xl > .list-group-item:first-child {
    border-bottom-left-radius: 0.25rem;
    border-top-right-radius: 0;
  }

  .list-group-horizontal-xl > .list-group-item:last-child {
    border-top-right-radius: 0.25rem;
    border-bottom-left-radius: 0;
  }

  .list-group-horizontal-xl > .list-group-item.active {
    margin-top: 0;
  }

  .list-group-horizontal-xl > .list-group-item + .list-group-item {
    border-top-width: 1px;
    border-left-width: 0;
  }

  .list-group-horizontal-xl > .list-group-item + .list-group-item.active {
    margin-left: -1px;
    border-left-width: 1px;
  }
}

.list-group-flush {
  border-radius: 0;
}

.list-group-flush > .list-group-item {
  border-width: 0 0 1px;
}

.list-group-flush > .list-group-item:last-child {
  border-bottom-width: 0;
}

.list-group-item-primary {
  color: #1b4b72;
  background-color: #c6e0f5;
}

.list-group-item-primary.list-group-item-action:hover,
.list-group-item-primary.list-group-item-action:focus {
  color: #1b4b72;
  background-color: #b0d4f1;
}

.list-group-item-primary.list-group-item-action.active {
  color: #fff;
  background-color: #1b4b72;
  border-color: #1b4b72;
}

.list-group-item-secondary {
  color: #383d41;
  background-color: #d6d8db;
}

.list-group-item-secondary.list-group-item-action:hover,
.list-group-item-secondary.list-group-item-action:focus {
  color: #383d41;
  background-color: #c8cbcf;
}

.list-group-item-secondary.list-group-item-action.active {
  color: #fff;
  background-color: #383d41;
  border-color: #383d41;
}

.list-group-item-success {
  color: #1d643b;
  background-color: #c7eed8;
}

.list-group-item-success.list-group-item-action:hover,
.list-group-item-success.list-group-item-action:focus {
  color: #1d643b;
  background-color: #b3e8ca;
}

.list-group-item-success.list-group-item-action.active {
  color: #fff;
  background-color: #1d643b;
  border-color: #1d643b;
}

.list-group-item-info {
  color: #385d7a;
  background-color: #d6e9f9;
}

.list-group-item-info.list-group-item-action:hover,
.list-group-item-info.list-group-item-action:focus {
  color: #385d7a;
  background-color: #c0ddf6;
}

.list-group-item-info.list-group-item-action.active {
  color: #fff;
  background-color: #385d7a;
  border-color: #385d7a;
}

.list-group-item-warning {
  color: #857b26;
  background-color: #fffacc;
}

.list-group-item-warning.list-group-item-action:hover,
.list-group-item-warning.list-group-item-action:focus {
  color: #857b26;
  background-color: #fff8b3;
}

.list-group-item-warning.list-group-item-action.active {
  color: #fff;
  background-color: #857b26;
  border-color: #857b26;
}

.list-group-item-danger {
  color: #761b18;
  background-color: #f7c6c5;
}

.list-group-item-danger.list-group-item-action:hover,
.list-group-item-danger.list-group-item-action:focus {
  color: #761b18;
  background-color: #f4b0af;
}

.list-group-item-danger.list-group-item-action.active {
  color: #fff;
  background-color: #761b18;
  border-color: #761b18;
}

.list-group-item-light {
  color: #818182;
  background-color: #fdfdfe;
}

.list-group-item-light.list-group-item-action:hover,
.list-group-item-light.list-group-item-action:focus {
  color: #818182;
  background-color: #ececf6;
}

.list-group-item-light.list-group-item-action.active {
  color: #fff;
  background-color: #818182;
  border-color: #818182;
}

.list-group-item-dark {
  color: #1b1e21;
  background-color: #c6c8ca;
}

.list-group-item-dark.list-group-item-action:hover,
.list-group-item-dark.list-group-item-action:focus {
  color: #1b1e21;
  background-color: #b9bbbe;
}

.list-group-item-dark.list-group-item-action.active {
  color: #fff;
  background-color: #1b1e21;
  border-color: #1b1e21;
}

.close {
  float: right;
  font-size: 1.35rem;
  font-weight: 700;
  line-height: 1;
  color: #000;
  text-shadow: 0 1px 0 #fff;
  opacity: 0.5;
}

.close:hover {
  color: #000;
  text-decoration: none;
}

.close:not(:disabled):not(.disabled):hover,
.close:not(:disabled):not(.disabled):focus {
  opacity: 0.75;
}

button.close {
  padding: 0;
  background-color: transparent;
  border: 0;
}

a.close.disabled {
  pointer-events: none;
}

.toast {
  flex-basis: 350px;
  max-width: 350px;
  font-size: 0.875rem;
  background-color: rgba(255, 255, 255, 0.85);
  background-clip: padding-box;
  border: 1px solid rgba(0, 0, 0, 0.1);
  box-shadow: 0 0.25rem 0.75rem rgba(0, 0, 0, 0.1);
  opacity: 0;
  border-radius: 0.25rem;
}

.toast:not(:last-child) {
  margin-bottom: 0.75rem;
}

.toast.showing {
  opacity: 1;
}

.toast.show {
  display: block;
  opacity: 1;
}

.toast.hide {
  display: none;
}

.toast-header {
  display: flex;
  align-items: center;
  padding: 0.25rem 0.75rem;
  color: #6c757d;
  background-color: rgba(255, 255, 255, 0.85);
  background-clip: padding-box;
  border-bottom: 1px solid rgba(0, 0, 0, 0.05);
  border-top-left-radius: calc(0.25rem - 1px);
  border-top-right-radius: calc(0.25rem - 1px);
}

.toast-body {
  padding: 0.75rem;
}

.modal-open {
  overflow: hidden;
}

.modal-open .modal {
  overflow-x: hidden;
  overflow-y: auto;
}

.modal {
  position: fixed;
  top: 0;
  left: 0;
  z-index: 1050;
  display: none;
  width: 100%;
  height: 100%;
  overflow: hidden;
  outline: 0;
}

.modal-dialog {
  position: relative;
  width: auto;
  margin: 0.5rem;
  pointer-events: none;
}

.modal.fade .modal-dialog {
  transition: transform 0.3s ease-out;
  transform: translate(0, -50px);
}

@media (prefers-reduced-motion: reduce) {
  .modal.fade .modal-dialog {
    transition: none;
  }
}

.modal.show .modal-dialog {
  transform: none;
}

.modal.modal-static .modal-dialog {
  transform: scale(1.02);
}

.modal-dialog-scrollable {
  display: flex;
  max-height: calc(100% - 1rem);
}

.modal-dialog-scrollable .modal-content {
  max-height: calc(100vh - 1rem);
  overflow: hidden;
}

.modal-dialog-scrollable .modal-header,
.modal-dialog-scrollable .modal-footer {
  flex-shrink: 0;
}

.modal-dialog-scrollable .modal-body {
  overflow-y: auto;
}

.modal-dialog-centered {
  display: flex;
  align-items: center;
  min-height: calc(100% - 1rem);
}

.modal-dialog-centered::before {
  display: block;
  height: calc(100vh - 1rem);
  height: -webkit-min-content;
  height: -moz-min-content;
  height: min-content;
  content: "";
}

.modal-dialog-centered.modal-dialog-scrollable {
  flex-direction: column;
  justify-content: center;
  height: 100%;
}

.modal-dialog-centered.modal-dialog-scrollable .modal-content {
  max-height: none;
}

.modal-dialog-centered.modal-dialog-scrollable::before {
  content: none;
}

.modal-content {
  position: relative;
  display: flex;
  flex-direction: column;
  width: 100%;
  pointer-events: auto;
  background-color: #fff;
  background-clip: padding-box;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 0.3rem;
  outline: 0;
}

.modal-backdrop {
  position: fixed;
  top: 0;
  left: 0;
  z-index: 1040;
  width: 100vw;
  height: 100vh;
  background-color: #000;
}

.modal-backdrop.fade {
  opacity: 0;
}

.modal-backdrop.show {
  opacity: 0.5;
}

.modal-header {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
  padding: 1rem 1rem;
  border-bottom: 1px solid #dee2e6;
  border-top-left-radius: calc(0.3rem - 1px);
  border-top-right-radius: calc(0.3rem - 1px);
}

.modal-header .close {
  padding: 1rem 1rem;
  margin: -1rem -1rem -1rem auto;
}

.modal-title {
  margin-bottom: 0;
  line-height: 1.6;
}

.modal-body {
  position: relative;
  flex: 1 1 auto;
  padding: 1rem;
}

.modal-footer {
  display: flex;
  flex-wrap: wrap;
  align-items: center;
  justify-content: flex-end;
  padding: 0.75rem;
  border-top: 1px solid #dee2e6;
  border-bottom-right-radius: calc(0.3rem - 1px);
  border-bottom-left-radius: calc(0.3rem - 1px);
}

.modal-footer > * {
  margin: 0.25rem;
}

.modal-scrollbar-measure {
  position: absolute;
  top: -9999px;
  width: 50px;
  height: 50px;
  overflow: scroll;
}

@media (min-width: 576px) {
  .modal-dialog {
    max-width: 500px;
    margin: 1.75rem auto;
  }

  .modal-dialog-scrollable {
    max-height: calc(100% - 3.5rem);
  }

  .modal-dialog-scrollable .modal-content {
    max-height: calc(100vh - 3.5rem);
  }

  .modal-dialog-centered {
    min-height: calc(100% - 3.5rem);
  }

  .modal-dialog-centered::before {
    height: calc(100vh - 3.5rem);
    height: -webkit-min-content;
    height: -moz-min-content;
    height: min-content;
  }

  .modal-sm {
    max-width: 300px;
  }
}

@media (min-width: 992px) {
  .modal-lg,
  .modal-xl {
    max-width: 800px;
  }
}

@media (min-width: 1200px) {
  .modal-xl {
    max-width: 1140px;
  }
}

.tooltip {
  position: absolute;
  z-index: 1070;
  display: block;
  margin: 0;
  font-family: "Nunito", sans-serif;
  font-style: normal;
  font-weight: 400;
  line-height: 1.6;
  text-align: left;
  text-align: start;
  text-decoration: none;
  text-shadow: none;
  text-transform: none;
  letter-spacing: normal;
  word-break: normal;
  word-spacing: normal;
  white-space: normal;
  line-break: auto;
  font-size: 0.7875rem;
  word-wrap: break-word;
  opacity: 0;
}

.tooltip.show {
  opacity: 0.9;
}

.tooltip .arrow {
  position: absolute;
  display: block;
  width: 0.8rem;
  height: 0.4rem;
}

.tooltip .arrow::before {
  position: absolute;
  content: "";
  border-color: transparent;
  border-style: solid;
}

.bs-tooltip-top,
.bs-tooltip-auto[x-placement^=top] {
  padding: 0.4rem 0;
}

.bs-tooltip-top .arrow,
.bs-tooltip-auto[x-placement^=top] .arrow {
  bottom: 0;
}

.bs-tooltip-top .arrow::before,
.bs-tooltip-auto[x-placement^=top] .arrow::before {
  top: 0;
  border-width: 0.4rem 0.4rem 0;
  border-top-color: #000;
}

.bs-tooltip-right,
.bs-tooltip-auto[x-placement^=right] {
  padding: 0 0.4rem;
}

.bs-tooltip-right .arrow,
.bs-tooltip-auto[x-placement^=right] .arrow {
  left: 0;
  width: 0.4rem;
  height: 0.8rem;
}

.bs-tooltip-right .arrow::before,
.bs-tooltip-auto[x-placement^=right] .arrow::before {
  right: 0;
  border-width: 0.4rem 0.4rem 0.4rem 0;
  border-right-color: #000;
}

.bs-tooltip-bottom,
.bs-tooltip-auto[x-placement^=bottom] {
  padding: 0.4rem 0;
}

.bs-tooltip-bottom .arrow,
.bs-tooltip-auto[x-placement^=bottom] .arrow {
  top: 0;
}

.bs-tooltip-bottom .arrow::before,
.bs-tooltip-auto[x-placement^=bottom] .arrow::before {
  bottom: 0;
  border-width: 0 0.4rem 0.4rem;
  border-bottom-color: #000;
}

.bs-tooltip-left,
.bs-tooltip-auto[x-placement^=left] {
  padding: 0 0.4rem;
}

.bs-tooltip-left .arrow,
.bs-tooltip-auto[x-placement^=left] .arrow {
  right: 0;
  width: 0.4rem;
  height: 0.8rem;
}

.bs-tooltip-left .arrow::before,
.bs-tooltip-auto[x-placement^=left] .arrow::before {
  left: 0;
  border-width: 0.4rem 0 0.4rem 0.4rem;
  border-left-color: #000;
}

.tooltip-inner {
  max-width: 200px;
  padding: 0.25rem 0.5rem;
  color: #fff;
  text-align: center;
  background-color: #000;
  border-radius: 0.25rem;
}

.popover {
  position: absolute;
  top: 0;
  left: 0;
  z-index: 1060;
  display: block;
  max-width: 276px;
  font-family: "Nunito", sans-serif;
  font-style: normal;
  font-weight: 400;
  line-height: 1.6;
  text-align: left;
  text-align: start;
  text-decoration: none;
  text-shadow: none;
  text-transform: none;
  letter-spacing: normal;
  word-break: normal;
  word-spacing: normal;
  white-space: normal;
  line-break: auto;
  font-size: 0.7875rem;
  word-wrap: break-word;
  background-color: #fff;
  background-clip: padding-box;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 0.3rem;
}

.popover .arrow {
  position: absolute;
  display: block;
  width: 1rem;
  height: 0.5rem;
  margin: 0 0.3rem;
}

.popover .arrow::before,
.popover .arrow::after {
  position: absolute;
  display: block;
  content: "";
  border-color: transparent;
  border-style: solid;
}

.bs-popover-top,
.bs-popover-auto[x-placement^=top] {
  margin-bottom: 0.5rem;
}

.bs-popover-top > .arrow,
.bs-popover-auto[x-placement^=top] > .arrow {
  bottom: calc(-0.5rem - 1px);
}

.bs-popover-top > .arrow::before,
.bs-popover-auto[x-placement^=top] > .arrow::before {
  bottom: 0;
  border-width: 0.5rem 0.5rem 0;
  border-top-color: rgba(0, 0, 0, 0.25);
}

.bs-popover-top > .arrow::after,
.bs-popover-auto[x-placement^=top] > .arrow::after {
  bottom: 1px;
  border-width: 0.5rem 0.5rem 0;
  border-top-color: #fff;
}

.bs-popover-right,
.bs-popover-auto[x-placement^=right] {
  margin-left: 0.5rem;
}

.bs-popover-right > .arrow,
.bs-popover-auto[x-placement^=right] > .arrow {
  left: calc(-0.5rem - 1px);
  width: 0.5rem;
  height: 1rem;
  margin: 0.3rem 0;
}

.bs-popover-right > .arrow::before,
.bs-popover-auto[x-placement^=right] > .arrow::before {
  left: 0;
  border-width: 0.5rem 0.5rem 0.5rem 0;
  border-right-color: rgba(0, 0, 0, 0.25);
}

.bs-popover-right > .arrow::after,
.bs-popover-auto[x-placement^=right] > .arrow::after {
  left: 1px;
  border-width: 0.5rem 0.5rem 0.5rem 0;
  border-right-color: #fff;
}

.bs-popover-bottom,
.bs-popover-auto[x-placement^=bottom] {
  margin-top: 0.5rem;
}

.bs-popover-bottom > .arrow,
.bs-popover-auto[x-placement^=bottom] > .arrow {
  top: calc(-0.5rem - 1px);
}

.bs-popover-bottom > .arrow::before,
.bs-popover-auto[x-placement^=bottom] > .arrow::before {
  top: 0;
  border-width: 0 0.5rem 0.5rem 0.5rem;
  border-bottom-color: rgba(0, 0, 0, 0.25);
}

.bs-popover-bottom > .arrow::after,
.bs-popover-auto[x-placement^=bottom] > .arrow::after {
  top: 1px;
  border-width: 0 0.5rem 0.5rem 0.5rem;
  border-bottom-color: #fff;
}

.bs-popover-bottom .popover-header::before,
.bs-popover-auto[x-placement^=bottom] .popover-header::before {
  position: absolute;
  top: 0;
  left: 50%;
  display: block;
  width: 1rem;
  margin-left: -0.5rem;
  content: "";
  border-bottom: 1px solid #f7f7f7;
}

.bs-popover-left,
.bs-popover-auto[x-placement^=left] {
  margin-right: 0.5rem;
}

.bs-popover-left > .arrow,
.bs-popover-auto[x-placement^=left] > .arrow {
  right: calc(-0.5rem - 1px);
  width: 0.5rem;
  height: 1rem;
  margin: 0.3rem 0;
}

.bs-popover-left > .arrow::before,
.bs-popover-auto[x-placement^=left] > .arrow::before {
  right: 0;
  border-width: 0.5rem 0 0.5rem 0.5rem;
  border-left-color: rgba(0, 0, 0, 0.25);
}

.bs-popover-left > .arrow::after,
.bs-popover-auto[x-placement^=left] > .arrow::after {
  right: 1px;
  border-width: 0.5rem 0 0.5rem 0.5rem;
  border-left-color: #fff;
}

.popover-header {
  padding: 0.5rem 0.75rem;
  margin-bottom: 0;
  font-size: 0.9rem;
  background-color: #f7f7f7;
  border-bottom: 1px solid #ebebeb;
  border-top-left-radius: calc(0.3rem - 1px);
  border-top-right-radius: calc(0.3rem - 1px);
}

.popover-header:empty {
  display: none;
}

.popover-body {
  padding: 0.5rem 0.75rem;
  color: #212529;
}

.carousel {
  position: relative;
}

.carousel.pointer-event {
  touch-action: pan-y;
}

.carousel-inner {
  position: relative;
  width: 100%;
  overflow: hidden;
}

.carousel-inner::after {
  display: block;
  clear: both;
  content: "";
}

.carousel-item {
  position: relative;
  display: none;
  float: left;
  width: 100%;
  margin-right: -100%;
  -webkit-backface-visibility: hidden;
          backface-visibility: hidden;
  transition: transform 0.6s ease-in-out;
}

@media (prefers-reduced-motion: reduce) {
  .carousel-item {
    transition: none;
  }
}

.carousel-item.active,
.carousel-item-next,
.carousel-item-prev {
  display: block;
}

.carousel-item-next:not(.carousel-item-left),
.active.carousel-item-right {
  transform: translateX(100%);
}

.carousel-item-prev:not(.carousel-item-right),
.active.carousel-item-left {
  transform: translateX(-100%);
}

.carousel-fade .carousel-item {
  opacity: 0;
  transition-property: opacity;
  transform: none;
}

.carousel-fade .carousel-item.active,
.carousel-fade .carousel-item-next.carousel-item-left,
.carousel-fade .carousel-item-prev.carousel-item-right {
  z-index: 1;
  opacity: 1;
}

.carousel-fade .active.carousel-item-left,
.carousel-fade .active.carousel-item-right {
  z-index: 0;
  opacity: 0;
  transition: opacity 0s 0.6s;
}

@media (prefers-reduced-motion: reduce) {
  .carousel-fade .active.carousel-item-left,
  .carousel-fade .active.carousel-item-right {
    transition: none;
  }
}

.carousel-control-prev,
.carousel-control-next {
  position: absolute;
  top: 0;
  bottom: 0;
  z-index: 1;
  display: flex;
  align-items: center;
  justify-content: center;
  width: 15%;
  color: #fff;
  text-align: center;
  opacity: 0.5;
  transition: opacity 0.15s ease;
}

@media (prefers-reduced-motion: reduce) {
  .carousel-control-prev,
  .carousel-control-next {
    transition: none;
  }
}

.carousel-control-prev:hover,
.carousel-control-prev:focus,
.carousel-control-next:hover,
.carousel-control-next:focus {
  color: #fff;
  text-decoration: none;
  outline: 0;
  opacity: 0.9;
}

.carousel-control-prev {
  left: 0;
}

.carousel-control-next {
  right: 0;
}

.carousel-control-prev-icon,
.carousel-control-next-icon {
  display: inline-block;
  width: 20px;
  height: 20px;
  background: no-repeat 50%/100% 100%;
}

.carousel-control-prev-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath d='M5.25 0l-4 4 4 4 1.5-1.5L4.25 4l2.5-2.5L5.25 0z'/%3e%3c/svg%3e");
}

.carousel-control-next-icon {
  background-image: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' fill='%23fff' width='8' height='8' viewBox='0 0 8 8'%3e%3cpath d='M2.75 0l-1.5 1.5L3.75 4l-2.5 2.5L2.75 8l4-4-4-4z'/%3e%3c/svg%3e");
}

.carousel-indicators {
  position: absolute;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 15;
  display: flex;
  justify-content: center;
  padding-left: 0;
  margin-right: 15%;
  margin-left: 15%;
  list-style: none;
}

.carousel-indicators li {
  box-sizing: content-box;
  flex: 0 1 auto;
  width: 30px;
  height: 3px;
  margin-right: 3px;
  margin-left: 3px;
  text-indent: -999px;
  cursor: pointer;
  background-color: #fff;
  background-clip: padding-box;
  border-top: 10px solid transparent;
  border-bottom: 10px solid transparent;
  opacity: 0.5;
  transition: opacity 0.6s ease;
}

@media (prefers-reduced-motion: reduce) {
  .carousel-indicators li {
    transition: none;
  }
}

.carousel-indicators .active {
  opacity: 1;
}

.carousel-caption {
  position: absolute;
  right: 15%;
  bottom: 20px;
  left: 15%;
  z-index: 10;
  padding-top: 20px;
  padding-bottom: 20px;
  color: #fff;
  text-align: center;
}

@-webkit-keyframes spinner-border {
  to {
    transform: rotate(360deg);
  }
}

@keyframes spinner-border {
  to {
    transform: rotate(360deg);
  }
}

.spinner-border {
  display: inline-block;
  width: 2rem;
  height: 2rem;
  vertical-align: text-bottom;
  border: 0.25em solid currentColor;
  border-right-color: transparent;
  border-radius: 50%;
  -webkit-animation: spinner-border 0.75s linear infinite;
          animation: spinner-border 0.75s linear infinite;
}

.spinner-border-sm {
  width: 1rem;
  height: 1rem;
  border-width: 0.2em;
}

@-webkit-keyframes spinner-grow {
  0% {
    transform: scale(0);
  }

  50% {
    opacity: 1;
    transform: none;
  }
}

@keyframes spinner-grow {
  0% {
    transform: scale(0);
  }

  50% {
    opacity: 1;
    transform: none;
  }
}

.spinner-grow {
  display: inline-block;
  width: 2rem;
  height: 2rem;
  vertical-align: text-bottom;
  background-color: currentColor;
  border-radius: 50%;
  opacity: 0;
  -webkit-animation: spinner-grow 0.75s linear infinite;
          animation: spinner-grow 0.75s linear infinite;
}

.spinner-grow-sm {
  width: 1rem;
  height: 1rem;
}

.align-baseline {
  vertical-align: baseline !important;
}

.align-top {
  vertical-align: top !important;
}

.align-middle {
  vertical-align: middle !important;
}

.align-bottom {
  vertical-align: bottom !important;
}

.align-text-bottom {
  vertical-align: text-bottom !important;
}

.align-text-top {
  vertical-align: text-top !important;
}

.bg-primary {
  background-color: #3490dc !important;
}

a.bg-primary:hover,
a.bg-primary:focus,
button.bg-primary:hover,
button.bg-primary:focus {
  background-color: #2176bd !important;
}

.bg-secondary {
  background-color: #6c757d !important;
}

a.bg-secondary:hover,
a.bg-secondary:focus,
button.bg-secondary:hover,
button.bg-secondary:focus {
  background-color: #545b62 !important;
}

.bg-success {
  background-color: #38c172 !important;
}

a.bg-success:hover,
a.bg-success:focus,
button.bg-success:hover,
button.bg-success:focus {
  background-color: #2d995b !important;
}

.bg-info {
  background-color: #6cb2eb !important;
}

a.bg-info:hover,
a.bg-info:focus,
button.bg-info:hover,
button.bg-info:focus {
  background-color: #3f9ae5 !important;
}

.bg-warning {
  background-color: #ffed4a !important;
}

a.bg-warning:hover,
a.bg-warning:focus,
button.bg-warning:hover,
button.bg-warning:focus {
  background-color: #ffe817 !important;
}

.bg-danger {
  background-color: #e3342f !important;
}

a.bg-danger:hover,
a.bg-danger:focus,
button.bg-danger:hover,
button.bg-danger:focus {
  background-color: #c51f1a !important;
}

.bg-light {
  background-color: #f8f9fa !important;
}

a.bg-light:hover,
a.bg-light:focus,
button.bg-light:hover,
button.bg-light:focus {
  background-color: #dae0e5 !important;
}

.bg-dark {
  background-color: #343a40 !important;
}

a.bg-dark:hover,
a.bg-dark:focus,
button.bg-dark:hover,
button.bg-dark:focus {
  background-color: #1d2124 !important;
}

.bg-white {
  background-color: #fff !important;
}

.bg-transparent {
  background-color: transparent !important;
}

.border {
  border: 1px solid #dee2e6 !important;
}

.border-top {
  border-top: 1px solid #dee2e6 !important;
}

.border-right {
  border-right: 1px solid #dee2e6 !important;
}

.border-bottom {
  border-bottom: 1px solid #dee2e6 !important;
}

.border-left {
  border-left: 1px solid #dee2e6 !important;
}

.border-0 {
  border: 0 !important;
}

.border-top-0 {
  border-top: 0 !important;
}

.border-right-0 {
  border-right: 0 !important;
}

.border-bottom-0 {
  border-bottom: 0 !important;
}

.border-left-0 {
  border-left: 0 !important;
}

.border-primary {
  border-color: #3490dc !important;
}

.border-secondary {
  border-color: #6c757d !important;
}

.border-success {
  border-color: #38c172 !important;
}

.border-info {
  border-color: #6cb2eb !important;
}

.border-warning {
  border-color: #ffed4a !important;
}

.border-danger {
  border-color: #e3342f !important;
}

.border-light {
  border-color: #f8f9fa !important;
}

.border-dark {
  border-color: #343a40 !important;
}

.border-white {
  border-color: #fff !important;
}

.rounded-sm {
  border-radius: 0.2rem !important;
}

.rounded {
  border-radius: 0.25rem !important;
}

.rounded-top {
  border-top-left-radius: 0.25rem !important;
  border-top-right-radius: 0.25rem !important;
}

.rounded-right {
  border-top-right-radius: 0.25rem !important;
  border-bottom-right-radius: 0.25rem !important;
}

.rounded-bottom {
  border-bottom-right-radius: 0.25rem !important;
  border-bottom-left-radius: 0.25rem !important;
}

.rounded-left {
  border-top-left-radius: 0.25rem !important;
  border-bottom-left-radius: 0.25rem !important;
}

.rounded-lg {
  border-radius: 0.3rem !important;
}

.rounded-circle {
  border-radius: 50% !important;
}

.rounded-pill {
  border-radius: 50rem !important;
}

.rounded-0 {
  border-radius: 0 !important;
}

.clearfix::after {
  display: block;
  clear: both;
  content: "";
}

.d-none {
  display: none !important;
}

.d-inline {
  display: inline !important;
}

.d-inline-block {
  display: inline-block !important;
}

.d-block {
  display: block !important;
}

.d-table {
  display: table !important;
}

.d-table-row {
  display: table-row !important;
}

.d-table-cell {
  display: table-cell !important;
}

.d-flex {
  display: flex !important;
}

.d-inline-flex {
  display: inline-flex !important;
}

@media (min-width: 576px) {
  .d-sm-none {
    display: none !important;
  }

  .d-sm-inline {
    display: inline !important;
  }

  .d-sm-inline-block {
    display: inline-block !important;
  }

  .d-sm-block {
    display: block !important;
  }

  .d-sm-table {
    display: table !important;
  }

  .d-sm-table-row {
    display: table-row !important;
  }

  .d-sm-table-cell {
    display: table-cell !important;
  }

  .d-sm-flex {
    display: flex !important;
  }

  .d-sm-inline-flex {
    display: inline-flex !important;
  }
}

@media (min-width: 768px) {
  .d-md-none {
    display: none !important;
  }

  .d-md-inline {
    display: inline !important;
  }

  .d-md-inline-block {
    display: inline-block !important;
  }

  .d-md-block {
    display: block !important;
  }

  .d-md-table {
    display: table !important;
  }

  .d-md-table-row {
    display: table-row !important;
  }

  .d-md-table-cell {
    display: table-cell !important;
  }

  .d-md-flex {
    display: flex !important;
  }

  .d-md-inline-flex {
    display: inline-flex !important;
  }
}

@media (min-width: 992px) {
  .d-lg-none {
    display: none !important;
  }

  .d-lg-inline {
    display: inline !important;
  }

  .d-lg-inline-block {
    display: inline-block !important;
  }

  .d-lg-block {
    display: block !important;
  }

  .d-lg-table {
    display: table !important;
  }

  .d-lg-table-row {
    display: table-row !important;
  }

  .d-lg-table-cell {
    display: table-cell !important;
  }

  .d-lg-flex {
    display: flex !important;
  }

  .d-lg-inline-flex {
    display: inline-flex !important;
  }
}

@media (min-width: 1200px) {
  .d-xl-none {
    display: none !important;
  }

  .d-xl-inline {
    display: inline !important;
  }

  .d-xl-inline-block {
    display: inline-block !important;
  }

  .d-xl-block {
    display: block !important;
  }

  .d-xl-table {
    display: table !important;
  }

  .d-xl-table-row {
    display: table-row !important;
  }

  .d-xl-table-cell {
    display: table-cell !important;
  }

  .d-xl-flex {
    display: flex !important;
  }

  .d-xl-inline-flex {
    display: inline-flex !important;
  }
}

@media print {
  .d-print-none {
    display: none !important;
  }

  .d-print-inline {
    display: inline !important;
  }

  .d-print-inline-block {
    display: inline-block !important;
  }

  .d-print-block {
    display: block !important;
  }

  .d-print-table {
    display: table !important;
  }

  .d-print-table-row {
    display: table-row !important;
  }

  .d-print-table-cell {
    display: table-cell !important;
  }

  .d-print-flex {
    display: flex !important;
  }

  .d-print-inline-flex {
    display: inline-flex !important;
  }
}

.embed-responsive {
  position: relative;
  display: block;
  width: 100%;
  padding: 0;
  overflow: hidden;
}

.embed-responsive::before {
  display: block;
  content: "";
}

.embed-responsive .embed-responsive-item,
.embed-responsive iframe,
.embed-responsive embed,
.embed-responsive object,
.embed-responsive video {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  width: 100%;
  height: 100%;
  border: 0;
}

.embed-responsive-21by9::before {
  padding-top: 42.8571428571%;
}

.embed-responsive-16by9::before {
  padding-top: 56.25%;
}

.embed-responsive-4by3::before {
  padding-top: 75%;
}

.embed-responsive-1by1::before {
  padding-top: 100%;
}

.flex-row {
  flex-direction: row !important;
}

.flex-column {
  flex-direction: column !important;
}

.flex-row-reverse {
  flex-direction: row-reverse !important;
}

.flex-column-reverse {
  flex-direction: column-reverse !important;
}

.flex-wrap {
  flex-wrap: wrap !important;
}

.flex-nowrap {
  flex-wrap: nowrap !important;
}

.flex-wrap-reverse {
  flex-wrap: wrap-reverse !important;
}

.flex-fill {
  flex: 1 1 auto !important;
}

.flex-grow-0 {
  flex-grow: 0 !important;
}

.flex-grow-1 {
  flex-grow: 1 !important;
}

.flex-shrink-0 {
  flex-shrink: 0 !important;
}

.flex-shrink-1 {
  flex-shrink: 1 !important;
}

.justify-content-start {
  justify-content: flex-start !important;
}

.justify-content-end {
  justify-content: flex-end !important;
}

.justify-content-center {
  justify-content: center !important;
}

.justify-content-between {
  justify-content: space-between !important;
}

.justify-content-around {
  justify-content: space-around !important;
}

.align-items-start {
  align-items: flex-start !important;
}

.align-items-end {
  align-items: flex-end !important;
}

.align-items-center {
  align-items: center !important;
}

.align-items-baseline {
  align-items: baseline !important;
}

.align-items-stretch {
  align-items: stretch !important;
}

.align-content-start {
  align-content: flex-start !important;
}

.align-content-end {
  align-content: flex-end !important;
}

.align-content-center {
  align-content: center !important;
}

.align-content-between {
  align-content: space-between !important;
}

.align-content-around {
  align-content: space-around !important;
}

.align-content-stretch {
  align-content: stretch !important;
}

.align-self-auto {
  align-self: auto !important;
}

.align-self-start {
  align-self: flex-start !important;
}

.align-self-end {
  align-self: flex-end !important;
}

.align-self-center {
  align-self: center !important;
}

.align-self-baseline {
  align-self: baseline !important;
}

.align-self-stretch {
  align-self: stretch !important;
}

@media (min-width: 576px) {
  .flex-sm-row {
    flex-direction: row !important;
  }

  .flex-sm-column {
    flex-direction: column !important;
  }

  .flex-sm-row-reverse {
    flex-direction: row-reverse !important;
  }

  .flex-sm-column-reverse {
    flex-direction: column-reverse !important;
  }

  .flex-sm-wrap {
    flex-wrap: wrap !important;
  }

  .flex-sm-nowrap {
    flex-wrap: nowrap !important;
  }

  .flex-sm-wrap-reverse {
    flex-wrap: wrap-reverse !important;
  }

  .flex-sm-fill {
    flex: 1 1 auto !important;
  }

  .flex-sm-grow-0 {
    flex-grow: 0 !important;
  }

  .flex-sm-grow-1 {
    flex-grow: 1 !important;
  }

  .flex-sm-shrink-0 {
    flex-shrink: 0 !important;
  }

  .flex-sm-shrink-1 {
    flex-shrink: 1 !important;
  }

  .justify-content-sm-start {
    justify-content: flex-start !important;
  }

  .justify-content-sm-end {
    justify-content: flex-end !important;
  }

  .justify-content-sm-center {
    justify-content: center !important;
  }

  .justify-content-sm-between {
    justify-content: space-between !important;
  }

  .justify-content-sm-around {
    justify-content: space-around !important;
  }

  .align-items-sm-start {
    align-items: flex-start !important;
  }

  .align-items-sm-end {
    align-items: flex-end !important;
  }

  .align-items-sm-center {
    align-items: center !important;
  }

  .align-items-sm-baseline {
    align-items: baseline !important;
  }

  .align-items-sm-stretch {
    align-items: stretch !important;
  }

  .align-content-sm-start {
    align-content: flex-start !important;
  }

  .align-content-sm-end {
    align-content: flex-end !important;
  }

  .align-content-sm-center {
    align-content: center !important;
  }

  .align-content-sm-between {
    align-content: space-between !important;
  }

  .align-content-sm-around {
    align-content: space-around !important;
  }

  .align-content-sm-stretch {
    align-content: stretch !important;
  }

  .align-self-sm-auto {
    align-self: auto !important;
  }

  .align-self-sm-start {
    align-self: flex-start !important;
  }

  .align-self-sm-end {
    align-self: flex-end !important;
  }

  .align-self-sm-center {
    align-self: center !important;
  }

  .align-self-sm-baseline {
    align-self: baseline !important;
  }

  .align-self-sm-stretch {
    align-self: stretch !important;
  }
}

@media (min-width: 768px) {
  .flex-md-row {
    flex-direction: row !important;
  }

  .flex-md-column {
    flex-direction: column !important;
  }

  .flex-md-row-reverse {
    flex-direction: row-reverse !important;
  }

  .flex-md-column-reverse {
    flex-direction: column-reverse !important;
  }

  .flex-md-wrap {
    flex-wrap: wrap !important;
  }

  .flex-md-nowrap {
    flex-wrap: nowrap !important;
  }

  .flex-md-wrap-reverse {
    flex-wrap: wrap-reverse !important;
  }

  .flex-md-fill {
    flex: 1 1 auto !important;
  }

  .flex-md-grow-0 {
    flex-grow: 0 !important;
  }

  .flex-md-grow-1 {
    flex-grow: 1 !important;
  }

  .flex-md-shrink-0 {
    flex-shrink: 0 !important;
  }

  .flex-md-shrink-1 {
    flex-shrink: 1 !important;
  }

  .justify-content-md-start {
    justify-content: flex-start !important;
  }

  .justify-content-md-end {
    justify-content: flex-end !important;
  }

  .justify-content-md-center {
    justify-content: center !important;
  }

  .justify-content-md-between {
    justify-content: space-between !important;
  }

  .justify-content-md-around {
    justify-content: space-around !important;
  }

  .align-items-md-start {
    align-items: flex-start !important;
  }

  .align-items-md-end {
    align-items: flex-end !important;
  }

  .align-items-md-center {
    align-items: center !important;
  }

  .align-items-md-baseline {
    align-items: baseline !important;
  }

  .align-items-md-stretch {
    align-items: stretch !important;
  }

  .align-content-md-start {
    align-content: flex-start !important;
  }

  .align-content-md-end {
    align-content: flex-end !important;
  }

  .align-content-md-center {
    align-content: center !important;
  }

  .align-content-md-between {
    align-content: space-between !important;
  }

  .align-content-md-around {
    align-content: space-around !important;
  }

  .align-content-md-stretch {
    align-content: stretch !important;
  }

  .align-self-md-auto {
    align-self: auto !important;
  }

  .align-self-md-start {
    align-self: flex-start !important;
  }

  .align-self-md-end {
    align-self: flex-end !important;
  }

  .align-self-md-center {
    align-self: center !important;
  }

  .align-self-md-baseline {
    align-self: baseline !important;
  }

  .align-self-md-stretch {
    align-self: stretch !important;
  }
}

@media (min-width: 992px) {
  .flex-lg-row {
    flex-direction: row !important;
  }

  .flex-lg-column {
    flex-direction: column !important;
  }

  .flex-lg-row-reverse {
    flex-direction: row-reverse !important;
  }

  .flex-lg-column-reverse {
    flex-direction: column-reverse !important;
  }

  .flex-lg-wrap {
    flex-wrap: wrap !important;
  }

  .flex-lg-nowrap {
    flex-wrap: nowrap !important;
  }

  .flex-lg-wrap-reverse {
    flex-wrap: wrap-reverse !important;
  }

  .flex-lg-fill {
    flex: 1 1 auto !important;
  }

  .flex-lg-grow-0 {
    flex-grow: 0 !important;
  }

  .flex-lg-grow-1 {
    flex-grow: 1 !important;
  }

  .flex-lg-shrink-0 {
    flex-shrink: 0 !important;
  }

  .flex-lg-shrink-1 {
    flex-shrink: 1 !important;
  }

  .justify-content-lg-start {
    justify-content: flex-start !important;
  }

  .justify-content-lg-end {
    justify-content: flex-end !important;
  }

  .justify-content-lg-center {
    justify-content: center !important;
  }

  .justify-content-lg-between {
    justify-content: space-between !important;
  }

  .justify-content-lg-around {
    justify-content: space-around !important;
  }

  .align-items-lg-start {
    align-items: flex-start !important;
  }

  .align-items-lg-end {
    align-items: flex-end !important;
  }

  .align-items-lg-center {
    align-items: center !important;
  }

  .align-items-lg-baseline {
    align-items: baseline !important;
  }

  .align-items-lg-stretch {
    align-items: stretch !important;
  }

  .align-content-lg-start {
    align-content: flex-start !important;
  }

  .align-content-lg-end {
    align-content: flex-end !important;
  }

  .align-content-lg-center {
    align-content: center !important;
  }

  .align-content-lg-between {
    align-content: space-between !important;
  }

  .align-content-lg-around {
    align-content: space-around !important;
  }

  .align-content-lg-stretch {
    align-content: stretch !important;
  }

  .align-self-lg-auto {
    align-self: auto !important;
  }

  .align-self-lg-start {
    align-self: flex-start !important;
  }

  .align-self-lg-end {
    align-self: flex-end !important;
  }

  .align-self-lg-center {
    align-self: center !important;
  }

  .align-self-lg-baseline {
    align-self: baseline !important;
  }

  .align-self-lg-stretch {
    align-self: stretch !important;
  }
}

@media (min-width: 1200px) {
  .flex-xl-row {
    flex-direction: row !important;
  }

  .flex-xl-column {
    flex-direction: column !important;
  }

  .flex-xl-row-reverse {
    flex-direction: row-reverse !important;
  }

  .flex-xl-column-reverse {
    flex-direction: column-reverse !important;
  }

  .flex-xl-wrap {
    flex-wrap: wrap !important;
  }

  .flex-xl-nowrap {
    flex-wrap: nowrap !important;
  }

  .flex-xl-wrap-reverse {
    flex-wrap: wrap-reverse !important;
  }

  .flex-xl-fill {
    flex: 1 1 auto !important;
  }

  .flex-xl-grow-0 {
    flex-grow: 0 !important;
  }

  .flex-xl-grow-1 {
    flex-grow: 1 !important;
  }

  .flex-xl-shrink-0 {
    flex-shrink: 0 !important;
  }

  .flex-xl-shrink-1 {
    flex-shrink: 1 !important;
  }

  .justify-content-xl-start {
    justify-content: flex-start !important;
  }

  .justify-content-xl-end {
    justify-content: flex-end !important;
  }

  .justify-content-xl-center {
    justify-content: center !important;
  }

  .justify-content-xl-between {
    justify-content: space-between !important;
  }

  .justify-content-xl-around {
    justify-content: space-around !important;
  }

  .align-items-xl-start {
    align-items: flex-start !important;
  }

  .align-items-xl-end {
    align-items: flex-end !important;
  }

  .align-items-xl-center {
    align-items: center !important;
  }

  .align-items-xl-baseline {
    align-items: baseline !important;
  }

  .align-items-xl-stretch {
    align-items: stretch !important;
  }

  .align-content-xl-start {
    align-content: flex-start !important;
  }

  .align-content-xl-end {
    align-content: flex-end !important;
  }

  .align-content-xl-center {
    align-content: center !important;
  }

  .align-content-xl-between {
    align-content: space-between !important;
  }

  .align-content-xl-around {
    align-content: space-around !important;
  }

  .align-content-xl-stretch {
    align-content: stretch !important;
  }

  .align-self-xl-auto {
    align-self: auto !important;
  }

  .align-self-xl-start {
    align-self: flex-start !important;
  }

  .align-self-xl-end {
    align-self: flex-end !important;
  }

  .align-self-xl-center {
    align-self: center !important;
  }

  .align-self-xl-baseline {
    align-self: baseline !important;
  }

  .align-self-xl-stretch {
    align-self: stretch !important;
  }
}

.float-left {
  float: left !important;
}

.float-right {
  float: right !important;
}

.float-none {
  float: none !important;
}

@media (min-width: 576px) {
  .float-sm-left {
    float: left !important;
  }

  .float-sm-right {
    float: right !important;
  }

  .float-sm-none {
    float: none !important;
  }
}

@media (min-width: 768px) {
  .float-md-left {
    float: left !important;
  }

  .float-md-right {
    float: right !important;
  }

  .float-md-none {
    float: none !important;
  }
}

@media (min-width: 992px) {
  .float-lg-left {
    float: left !important;
  }

  .float-lg-right {
    float: right !important;
  }

  .float-lg-none {
    float: none !important;
  }
}

@media (min-width: 1200px) {
  .float-xl-left {
    float: left !important;
  }

  .float-xl-right {
    float: right !important;
  }

  .float-xl-none {
    float: none !important;
  }
}

.user-select-all {
  -webkit-user-select: all !important;
     -moz-user-select: all !important;
      -ms-user-select: all !important;
          user-select: all !important;
}

.user-select-auto {
  -webkit-user-select: auto !important;
     -moz-user-select: auto !important;
      -ms-user-select: auto !important;
          user-select: auto !important;
}

.user-select-none {
  -webkit-user-select: none !important;
     -moz-user-select: none !important;
      -ms-user-select: none !important;
          user-select: none !important;
}

.overflow-auto {
  overflow: auto !important;
}

.overflow-hidden {
  overflow: hidden !important;
}

.position-static {
  position: static !important;
}

.position-relative {
  position: relative !important;
}

.position-absolute {
  position: absolute !important;
}

.position-fixed {
  position: fixed !important;
}

.position-sticky {
  position: -webkit-sticky !important;
  position: sticky !important;
}

.fixed-top {
  position: fixed;
  top: 0;
  right: 0;
  left: 0;
  z-index: 1030;
}

.fixed-bottom {
  position: fixed;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1030;
}

@supports ((position: -webkit-sticky) or (position: sticky)) {
  .sticky-top {
    position: -webkit-sticky;
    position: sticky;
    top: 0;
    z-index: 1020;
  }
}

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  padding: 0;
  margin: -1px;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  white-space: nowrap;
  border: 0;
}

.sr-only-focusable:active,
.sr-only-focusable:focus {
  position: static;
  width: auto;
  height: auto;
  overflow: visible;
  clip: auto;
  white-space: normal;
}

.shadow-sm {
  box-shadow: 0 0.125rem 0.25rem rgba(0, 0, 0, 0.075) !important;
}

.shadow {
  box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.15) !important;
}

.shadow-lg {
  box-shadow: 0 1rem 3rem rgba(0, 0, 0, 0.175) !important;
}

.shadow-none {
  box-shadow: none !important;
}

.w-25 {
  width: 25% !important;
}

.w-50 {
  width: 50% !important;
}

.w-75 {
  width: 75% !important;
}

.w-100 {
  width: 100% !important;
}

.w-auto {
  width: auto !important;
}

.h-25 {
  height: 25% !important;
}

.h-50 {
  height: 50% !important;
}

.h-75 {
  height: 75% !important;
}

.h-100 {
  height: 100% !important;
}

.h-auto {
  height: auto !important;
}

.mw-100 {
  max-width: 100% !important;
}

.mh-100 {
  max-height: 100% !important;
}

.min-vw-100 {
  min-width: 100vw !important;
}

.min-vh-100 {
  min-height: 100vh !important;
}

.vw-100 {
  width: 100vw !important;
}

.vh-100 {
  height: 100vh !important;
}

.m-0 {
  margin: 0 !important;
}

.mt-0,
.my-0 {
  margin-top: 0 !important;
}

.mr-0,
.mx-0 {
  margin-right: 0 !important;
}

.mb-0,
.my-0 {
  margin-bottom: 0 !important;
}

.ml-0,
.mx-0 {
  margin-left: 0 !important;
}

.m-1 {
  margin: 0.25rem !important;
}

.mt-1,
.my-1 {
  margin-top: 0.25rem !important;
}

.mr-1,
.mx-1 {
  margin-right: 0.25rem !important;
}

.mb-1,
.my-1 {
  margin-bottom: 0.25rem !important;
}

.ml-1,
.mx-1 {
  margin-left: 0.25rem !important;
}

.m-2 {
  margin: 0.5rem !important;
}

.mt-2,
.my-2 {
  margin-top: 0.5rem !important;
}

.mr-2,
.mx-2 {
  margin-right: 0.5rem !important;
}

.mb-2,
.my-2 {
  margin-bottom: 0.5rem !important;
}

.ml-2,
.mx-2 {
  margin-left: 0.5rem !important;
}

.m-3 {
  margin: 1rem !important;
}

.mt-3,
.my-3 {
  margin-top: 1rem !important;
}

.mr-3,
.mx-3 {
  margin-right: 1rem !important;
}

.mb-3,
.my-3 {
  margin-bottom: 1rem !important;
}

.ml-3,
.mx-3 {
  margin-left: 1rem !important;
}

.m-4 {
  margin: 1.5rem !important;
}

.mt-4,
.my-4 {
  margin-top: 1.5rem !important;
}

.mr-4,
.mx-4 {
  margin-right: 1.5rem !important;
}

.mb-4,
.my-4 {
  margin-bottom: 1.5rem !important;
}

.ml-4,
.mx-4 {
  margin-left: 1.5rem !important;
}

.m-5 {
  margin: 3rem !important;
}

.mt-5,
.my-5 {
  margin-top: 3rem !important;
}

.mr-5,
.mx-5 {
  margin-right: 3rem !important;
}

.mb-5,
.my-5 {
  margin-bottom: 3rem !important;
}

.ml-5,
.mx-5 {
  margin-left: 3rem !important;
}

.p-0 {
  padding: 0 !important;
}

.pt-0,
.py-0 {
  padding-top: 0 !important;
}

.pr-0,
.px-0 {
  padding-right: 0 !important;
}

.pb-0,
.py-0 {
  padding-bottom: 0 !important;
}

.pl-0,
.px-0 {
  padding-left: 0 !important;
}

.p-1 {
  padding: 0.25rem !important;
}

.pt-1,
.py-1 {
  padding-top: 0.25rem !important;
}

.pr-1,
.px-1 {
  padding-right: 0.25rem !important;
}

.pb-1,
.py-1 {
  padding-bottom: 0.25rem !important;
}

.pl-1,
.px-1 {
  padding-left: 0.25rem !important;
}

.p-2 {
  padding: 0.5rem !important;
}

.pt-2,
.py-2 {
  padding-top: 0.5rem !important;
}

.pr-2,
.px-2 {
  padding-right: 0.5rem !important;
}

.pb-2,
.py-2 {
  padding-bottom: 0.5rem !important;
}

.pl-2,
.px-2 {
  padding-left: 0.5rem !important;
}

.p-3 {
  padding: 1rem !important;
}

.pt-3,
.py-3 {
  padding-top: 1rem !important;
}

.pr-3,
.px-3 {
  padding-right: 1rem !important;
}

.pb-3,
.py-3 {
  padding-bottom: 1rem !important;
}

.pl-3,
.px-3 {
  padding-left: 1rem !important;
}

.p-4 {
  padding: 1.5rem !important;
}

.pt-4,
.py-4 {
  padding-top: 1.5rem !important;
}

.pr-4,
.px-4 {
  padding-right: 1.5rem !important;
}

.pb-4,
.py-4 {
  padding-bottom: 1.5rem !important;
}

.pl-4,
.px-4 {
  padding-left: 1.5rem !important;
}

.p-5 {
  padding: 3rem !important;
}

.pt-5,
.py-5 {
  padding-top: 3rem !important;
}

.pr-5,
.px-5 {
  padding-right: 3rem !important;
}

.pb-5,
.py-5 {
  padding-bottom: 3rem !important;
}

.pl-5,
.px-5 {
  padding-left: 3rem !important;
}

.m-n1 {
  margin: -0.25rem !important;
}

.mt-n1,
.my-n1 {
  margin-top: -0.25rem !important;
}

.mr-n1,
.mx-n1 {
  margin-right: -0.25rem !important;
}

.mb-n1,
.my-n1 {
  margin-bottom: -0.25rem !important;
}

.ml-n1,
.mx-n1 {
  margin-left: -0.25rem !important;
}

.m-n2 {
  margin: -0.5rem !important;
}

.mt-n2,
.my-n2 {
  margin-top: -0.5rem !important;
}

.mr-n2,
.mx-n2 {
  margin-right: -0.5rem !important;
}

.mb-n2,
.my-n2 {
  margin-bottom: -0.5rem !important;
}

.ml-n2,
.mx-n2 {
  margin-left: -0.5rem !important;
}

.m-n3 {
  margin: -1rem !important;
}

.mt-n3,
.my-n3 {
  margin-top: -1rem !important;
}

.mr-n3,
.mx-n3 {
  margin-right: -1rem !important;
}

.mb-n3,
.my-n3 {
  margin-bottom: -1rem !important;
}

.ml-n3,
.mx-n3 {
  margin-left: -1rem !important;
}

.m-n4 {
  margin: -1.5rem !important;
}

.mt-n4,
.my-n4 {
  margin-top: -1.5rem !important;
}

.mr-n4,
.mx-n4 {
  margin-right: -1.5rem !important;
}

.mb-n4,
.my-n4 {
  margin-bottom: -1.5rem !important;
}

.ml-n4,
.mx-n4 {
  margin-left: -1.5rem !important;
}

.m-n5 {
  margin: -3rem !important;
}

.mt-n5,
.my-n5 {
  margin-top: -3rem !important;
}

.mr-n5,
.mx-n5 {
  margin-right: -3rem !important;
}

.mb-n5,
.my-n5 {
  margin-bottom: -3rem !important;
}

.ml-n5,
.mx-n5 {
  margin-left: -3rem !important;
}

.m-auto {
  margin: auto !important;
}

.mt-auto,
.my-auto {
  margin-top: auto !important;
}

.mr-auto,
.mx-auto {
  margin-right: auto !important;
}

.mb-auto,
.my-auto {
  margin-bottom: auto !important;
}

.ml-auto,
.mx-auto {
  margin-left: auto !important;
}

@media (min-width: 576px) {
  .m-sm-0 {
    margin: 0 !important;
  }

  .mt-sm-0,
  .my-sm-0 {
    margin-top: 0 !important;
  }

  .mr-sm-0,
  .mx-sm-0 {
    margin-right: 0 !important;
  }

  .mb-sm-0,
  .my-sm-0 {
    margin-bottom: 0 !important;
  }

  .ml-sm-0,
  .mx-sm-0 {
    margin-left: 0 !important;
  }

  .m-sm-1 {
    margin: 0.25rem !important;
  }

  .mt-sm-1,
  .my-sm-1 {
    margin-top: 0.25rem !important;
  }

  .mr-sm-1,
  .mx-sm-1 {
    margin-right: 0.25rem !important;
  }

  .mb-sm-1,
  .my-sm-1 {
    margin-bottom: 0.25rem !important;
  }

  .ml-sm-1,
  .mx-sm-1 {
    margin-left: 0.25rem !important;
  }

  .m-sm-2 {
    margin: 0.5rem !important;
  }

  .mt-sm-2,
  .my-sm-2 {
    margin-top: 0.5rem !important;
  }

  .mr-sm-2,
  .mx-sm-2 {
    margin-right: 0.5rem !important;
  }

  .mb-sm-2,
  .my-sm-2 {
    margin-bottom: 0.5rem !important;
  }

  .ml-sm-2,
  .mx-sm-2 {
    margin-left: 0.5rem !important;
  }

  .m-sm-3 {
    margin: 1rem !important;
  }

  .mt-sm-3,
  .my-sm-3 {
    margin-top: 1rem !important;
  }

  .mr-sm-3,
  .mx-sm-3 {
    margin-right: 1rem !important;
  }

  .mb-sm-3,
  .my-sm-3 {
    margin-bottom: 1rem !important;
  }

  .ml-sm-3,
  .mx-sm-3 {
    margin-left: 1rem !important;
  }

  .m-sm-4 {
    margin: 1.5rem !important;
  }

  .mt-sm-4,
  .my-sm-4 {
    margin-top: 1.5rem !important;
  }

  .mr-sm-4,
  .mx-sm-4 {
    margin-right: 1.5rem !important;
  }

  .mb-sm-4,
  .my-sm-4 {
    margin-bottom: 1.5rem !important;
  }

  .ml-sm-4,
  .mx-sm-4 {
    margin-left: 1.5rem !important;
  }

  .m-sm-5 {
    margin: 3rem !important;
  }

  .mt-sm-5,
  .my-sm-5 {
    margin-top: 3rem !important;
  }

  .mr-sm-5,
  .mx-sm-5 {
    margin-right: 3rem !important;
  }

  .mb-sm-5,
  .my-sm-5 {
    margin-bottom: 3rem !important;
  }

  .ml-sm-5,
  .mx-sm-5 {
    margin-left: 3rem !important;
  }

  .p-sm-0 {
    padding: 0 !important;
  }

  .pt-sm-0,
  .py-sm-0 {
    padding-top: 0 !important;
  }

  .pr-sm-0,
  .px-sm-0 {
    padding-right: 0 !important;
  }

  .pb-sm-0,
  .py-sm-0 {
    padding-bottom: 0 !important;
  }

  .pl-sm-0,
  .px-sm-0 {
    padding-left: 0 !important;
  }

  .p-sm-1 {
    padding: 0.25rem !important;
  }

  .pt-sm-1,
  .py-sm-1 {
    padding-top: 0.25rem !important;
  }

  .pr-sm-1,
  .px-sm-1 {
    padding-right: 0.25rem !important;
  }

  .pb-sm-1,
  .py-sm-1 {
    padding-bottom: 0.25rem !important;
  }

  .pl-sm-1,
  .px-sm-1 {
    padding-left: 0.25rem !important;
  }

  .p-sm-2 {
    padding: 0.5rem !important;
  }

  .pt-sm-2,
  .py-sm-2 {
    padding-top: 0.5rem !important;
  }

  .pr-sm-2,
  .px-sm-2 {
    padding-right: 0.5rem !important;
  }

  .pb-sm-2,
  .py-sm-2 {
    padding-bottom: 0.5rem !important;
  }

  .pl-sm-2,
  .px-sm-2 {
    padding-left: 0.5rem !important;
  }

  .p-sm-3 {
    padding: 1rem !important;
  }

  .pt-sm-3,
  .py-sm-3 {
    padding-top: 1rem !important;
  }

  .pr-sm-3,
  .px-sm-3 {
    padding-right: 1rem !important;
  }

  .pb-sm-3,
  .py-sm-3 {
    padding-bottom: 1rem !important;
  }

  .pl-sm-3,
  .px-sm-3 {
    padding-left: 1rem !important;
  }

  .p-sm-4 {
    padding: 1.5rem !important;
  }

  .pt-sm-4,
  .py-sm-4 {
    padding-top: 1.5rem !important;
  }

  .pr-sm-4,
  .px-sm-4 {
    padding-right: 1.5rem !important;
  }

  .pb-sm-4,
  .py-sm-4 {
    padding-bottom: 1.5rem !important;
  }

  .pl-sm-4,
  .px-sm-4 {
    padding-left: 1.5rem !important;
  }

  .p-sm-5 {
    padding: 3rem !important;
  }

  .pt-sm-5,
  .py-sm-5 {
    padding-top: 3rem !important;
  }

  .pr-sm-5,
  .px-sm-5 {
    padding-right: 3rem !important;
  }

  .pb-sm-5,
  .py-sm-5 {
    padding-bottom: 3rem !important;
  }

  .pl-sm-5,
  .px-sm-5 {
    padding-left: 3rem !important;
  }

  .m-sm-n1 {
    margin: -0.25rem !important;
  }

  .mt-sm-n1,
  .my-sm-n1 {
    margin-top: -0.25rem !important;
  }

  .mr-sm-n1,
  .mx-sm-n1 {
    margin-right: -0.25rem !important;
  }

  .mb-sm-n1,
  .my-sm-n1 {
    margin-bottom: -0.25rem !important;
  }

  .ml-sm-n1,
  .mx-sm-n1 {
    margin-left: -0.25rem !important;
  }

  .m-sm-n2 {
    margin: -0.5rem !important;
  }

  .mt-sm-n2,
  .my-sm-n2 {
    margin-top: -0.5rem !important;
  }

  .mr-sm-n2,
  .mx-sm-n2 {
    margin-right: -0.5rem !important;
  }

  .mb-sm-n2,
  .my-sm-n2 {
    margin-bottom: -0.5rem !important;
  }

  .ml-sm-n2,
  .mx-sm-n2 {
    margin-left: -0.5rem !important;
  }

  .m-sm-n3 {
    margin: -1rem !important;
  }

  .mt-sm-n3,
  .my-sm-n3 {
    margin-top: -1rem !important;
  }

  .mr-sm-n3,
  .mx-sm-n3 {
    margin-right: -1rem !important;
  }

  .mb-sm-n3,
  .my-sm-n3 {
    margin-bottom: -1rem !important;
  }

  .ml-sm-n3,
  .mx-sm-n3 {
    margin-left: -1rem !important;
  }

  .m-sm-n4 {
    margin: -1.5rem !important;
  }

  .mt-sm-n4,
  .my-sm-n4 {
    margin-top: -1.5rem !important;
  }

  .mr-sm-n4,
  .mx-sm-n4 {
    margin-right: -1.5rem !important;
  }

  .mb-sm-n4,
  .my-sm-n4 {
    margin-bottom: -1.5rem !important;
  }

  .ml-sm-n4,
  .mx-sm-n4 {
    margin-left: -1.5rem !important;
  }

  .m-sm-n5 {
    margin: -3rem !important;
  }

  .mt-sm-n5,
  .my-sm-n5 {
    margin-top: -3rem !important;
  }

  .mr-sm-n5,
  .mx-sm-n5 {
    margin-right: -3rem !important;
  }

  .mb-sm-n5,
  .my-sm-n5 {
    margin-bottom: -3rem !important;
  }

  .ml-sm-n5,
  .mx-sm-n5 {
    margin-left: -3rem !important;
  }

  .m-sm-auto {
    margin: auto !important;
  }

  .mt-sm-auto,
  .my-sm-auto {
    margin-top: auto !important;
  }

  .mr-sm-auto,
  .mx-sm-auto {
    margin-right: auto !important;
  }

  .mb-sm-auto,
  .my-sm-auto {
    margin-bottom: auto !important;
  }

  .ml-sm-auto,
  .mx-sm-auto {
    margin-left: auto !important;
  }
}

@media (min-width: 768px) {
  .m-md-0 {
    margin: 0 !important;
  }

  .mt-md-0,
  .my-md-0 {
    margin-top: 0 !important;
  }

  .mr-md-0,
  .mx-md-0 {
    margin-right: 0 !important;
  }

  .mb-md-0,
  .my-md-0 {
    margin-bottom: 0 !important;
  }

  .ml-md-0,
  .mx-md-0 {
    margin-left: 0 !important;
  }

  .m-md-1 {
    margin: 0.25rem !important;
  }

  .mt-md-1,
  .my-md-1 {
    margin-top: 0.25rem !important;
  }

  .mr-md-1,
  .mx-md-1 {
    margin-right: 0.25rem !important;
  }

  .mb-md-1,
  .my-md-1 {
    margin-bottom: 0.25rem !important;
  }

  .ml-md-1,
  .mx-md-1 {
    margin-left: 0.25rem !important;
  }

  .m-md-2 {
    margin: 0.5rem !important;
  }

  .mt-md-2,
  .my-md-2 {
    margin-top: 0.5rem !important;
  }

  .mr-md-2,
  .mx-md-2 {
    margin-right: 0.5rem !important;
  }

  .mb-md-2,
  .my-md-2 {
    margin-bottom: 0.5rem !important;
  }

  .ml-md-2,
  .mx-md-2 {
    margin-left: 0.5rem !important;
  }

  .m-md-3 {
    margin: 1rem !important;
  }

  .mt-md-3,
  .my-md-3 {
    margin-top: 1rem !important;
  }

  .mr-md-3,
  .mx-md-3 {
    margin-right: 1rem !important;
  }

  .mb-md-3,
  .my-md-3 {
    margin-bottom: 1rem !important;
  }

  .ml-md-3,
  .mx-md-3 {
    margin-left: 1rem !important;
  }

  .m-md-4 {
    margin: 1.5rem !important;
  }

  .mt-md-4,
  .my-md-4 {
    margin-top: 1.5rem !important;
  }

  .mr-md-4,
  .mx-md-4 {
    margin-right: 1.5rem !important;
  }

  .mb-md-4,
  .my-md-4 {
    margin-bottom: 1.5rem !important;
  }

  .ml-md-4,
  .mx-md-4 {
    margin-left: 1.5rem !important;
  }

  .m-md-5 {
    margin: 3rem !important;
  }

  .mt-md-5,
  .my-md-5 {
    margin-top: 3rem !important;
  }

  .mr-md-5,
  .mx-md-5 {
    margin-right: 3rem !important;
  }

  .mb-md-5,
  .my-md-5 {
    margin-bottom: 3rem !important;
  }

  .ml-md-5,
  .mx-md-5 {
    margin-left: 3rem !important;
  }

  .p-md-0 {
    padding: 0 !important;
  }

  .pt-md-0,
  .py-md-0 {
    padding-top: 0 !important;
  }

  .pr-md-0,
  .px-md-0 {
    padding-right: 0 !important;
  }

  .pb-md-0,
  .py-md-0 {
    padding-bottom: 0 !important;
  }

  .pl-md-0,
  .px-md-0 {
    padding-left: 0 !important;
  }

  .p-md-1 {
    padding: 0.25rem !important;
  }

  .pt-md-1,
  .py-md-1 {
    padding-top: 0.25rem !important;
  }

  .pr-md-1,
  .px-md-1 {
    padding-right: 0.25rem !important;
  }

  .pb-md-1,
  .py-md-1 {
    padding-bottom: 0.25rem !important;
  }

  .pl-md-1,
  .px-md-1 {
    padding-left: 0.25rem !important;
  }

  .p-md-2 {
    padding: 0.5rem !important;
  }

  .pt-md-2,
  .py-md-2 {
    padding-top: 0.5rem !important;
  }

  .pr-md-2,
  .px-md-2 {
    padding-right: 0.5rem !important;
  }

  .pb-md-2,
  .py-md-2 {
    padding-bottom: 0.5rem !important;
  }

  .pl-md-2,
  .px-md-2 {
    padding-left: 0.5rem !important;
  }

  .p-md-3 {
    padding: 1rem !important;
  }

  .pt-md-3,
  .py-md-3 {
    padding-top: 1rem !important;
  }

  .pr-md-3,
  .px-md-3 {
    padding-right: 1rem !important;
  }

  .pb-md-3,
  .py-md-3 {
    padding-bottom: 1rem !important;
  }

  .pl-md-3,
  .px-md-3 {
    padding-left: 1rem !important;
  }

  .p-md-4 {
    padding: 1.5rem !important;
  }

  .pt-md-4,
  .py-md-4 {
    padding-top: 1.5rem !important;
  }

  .pr-md-4,
  .px-md-4 {
    padding-right: 1.5rem !important;
  }

  .pb-md-4,
  .py-md-4 {
    padding-bottom: 1.5rem !important;
  }

  .pl-md-4,
  .px-md-4 {
    padding-left: 1.5rem !important;
  }

  .p-md-5 {
    padding: 3rem !important;
  }

  .pt-md-5,
  .py-md-5 {
    padding-top: 3rem !important;
  }

  .pr-md-5,
  .px-md-5 {
    padding-right: 3rem !important;
  }

  .pb-md-5,
  .py-md-5 {
    padding-bottom: 3rem !important;
  }

  .pl-md-5,
  .px-md-5 {
    padding-left: 3rem !important;
  }

  .m-md-n1 {
    margin: -0.25rem !important;
  }

  .mt-md-n1,
  .my-md-n1 {
    margin-top: -0.25rem !important;
  }

  .mr-md-n1,
  .mx-md-n1 {
    margin-right: -0.25rem !important;
  }

  .mb-md-n1,
  .my-md-n1 {
    margin-bottom: -0.25rem !important;
  }

  .ml-md-n1,
  .mx-md-n1 {
    margin-left: -0.25rem !important;
  }

  .m-md-n2 {
    margin: -0.5rem !important;
  }

  .mt-md-n2,
  .my-md-n2 {
    margin-top: -0.5rem !important;
  }

  .mr-md-n2,
  .mx-md-n2 {
    margin-right: -0.5rem !important;
  }

  .mb-md-n2,
  .my-md-n2 {
    margin-bottom: -0.5rem !important;
  }

  .ml-md-n2,
  .mx-md-n2 {
    margin-left: -0.5rem !important;
  }

  .m-md-n3 {
    margin: -1rem !important;
  }

  .mt-md-n3,
  .my-md-n3 {
    margin-top: -1rem !important;
  }

  .mr-md-n3,
  .mx-md-n3 {
    margin-right: -1rem !important;
  }

  .mb-md-n3,
  .my-md-n3 {
    margin-bottom: -1rem !important;
  }

  .ml-md-n3,
  .mx-md-n3 {
    margin-left: -1rem !important;
  }

  .m-md-n4 {
    margin: -1.5rem !important;
  }

  .mt-md-n4,
  .my-md-n4 {
    margin-top: -1.5rem !important;
  }

  .mr-md-n4,
  .mx-md-n4 {
    margin-right: -1.5rem !important;
  }

  .mb-md-n4,
  .my-md-n4 {
    margin-bottom: -1.5rem !important;
  }

  .ml-md-n4,
  .mx-md-n4 {
    margin-left: -1.5rem !important;
  }

  .m-md-n5 {
    margin: -3rem !important;
  }

  .mt-md-n5,
  .my-md-n5 {
    margin-top: -3rem !important;
  }

  .mr-md-n5,
  .mx-md-n5 {
    margin-right: -3rem !important;
  }

  .mb-md-n5,
  .my-md-n5 {
    margin-bottom: -3rem !important;
  }

  .ml-md-n5,
  .mx-md-n5 {
    margin-left: -3rem !important;
  }

  .m-md-auto {
    margin: auto !important;
  }

  .mt-md-auto,
  .my-md-auto {
    margin-top: auto !important;
  }

  .mr-md-auto,
  .mx-md-auto {
    margin-right: auto !important;
  }

  .mb-md-auto,
  .my-md-auto {
    margin-bottom: auto !important;
  }

  .ml-md-auto,
  .mx-md-auto {
    margin-left: auto !important;
  }
}

@media (min-width: 992px) {
  .m-lg-0 {
    margin: 0 !important;
  }

  .mt-lg-0,
  .my-lg-0 {
    margin-top: 0 !important;
  }

  .mr-lg-0,
  .mx-lg-0 {
    margin-right: 0 !important;
  }

  .mb-lg-0,
  .my-lg-0 {
    margin-bottom: 0 !important;
  }

  .ml-lg-0,
  .mx-lg-0 {
    margin-left: 0 !important;
  }

  .m-lg-1 {
    margin: 0.25rem !important;
  }

  .mt-lg-1,
  .my-lg-1 {
    margin-top: 0.25rem !important;
  }

  .mr-lg-1,
  .mx-lg-1 {
    margin-right: 0.25rem !important;
  }

  .mb-lg-1,
  .my-lg-1 {
    margin-bottom: 0.25rem !important;
  }

  .ml-lg-1,
  .mx-lg-1 {
    margin-left: 0.25rem !important;
  }

  .m-lg-2 {
    margin: 0.5rem !important;
  }

  .mt-lg-2,
  .my-lg-2 {
    margin-top: 0.5rem !important;
  }

  .mr-lg-2,
  .mx-lg-2 {
    margin-right: 0.5rem !important;
  }

  .mb-lg-2,
  .my-lg-2 {
    margin-bottom: 0.5rem !important;
  }

  .ml-lg-2,
  .mx-lg-2 {
    margin-left: 0.5rem !important;
  }

  .m-lg-3 {
    margin: 1rem !important;
  }

  .mt-lg-3,
  .my-lg-3 {
    margin-top: 1rem !important;
  }

  .mr-lg-3,
  .mx-lg-3 {
    margin-right: 1rem !important;
  }

  .mb-lg-3,
  .my-lg-3 {
    margin-bottom: 1rem !important;
  }

  .ml-lg-3,
  .mx-lg-3 {
    margin-left: 1rem !important;
  }

  .m-lg-4 {
    margin: 1.5rem !important;
  }

  .mt-lg-4,
  .my-lg-4 {
    margin-top: 1.5rem !important;
  }

  .mr-lg-4,
  .mx-lg-4 {
    margin-right: 1.5rem !important;
  }

  .mb-lg-4,
  .my-lg-4 {
    margin-bottom: 1.5rem !important;
  }

  .ml-lg-4,
  .mx-lg-4 {
    margin-left: 1.5rem !important;
  }

  .m-lg-5 {
    margin: 3rem !important;
  }

  .mt-lg-5,
  .my-lg-5 {
    margin-top: 3rem !important;
  }

  .mr-lg-5,
  .mx-lg-5 {
    margin-right: 3rem !important;
  }

  .mb-lg-5,
  .my-lg-5 {
    margin-bottom: 3rem !important;
  }

  .ml-lg-5,
  .mx-lg-5 {
    margin-left: 3rem !important;
  }

  .p-lg-0 {
    padding: 0 !important;
  }

  .pt-lg-0,
  .py-lg-0 {
    padding-top: 0 !important;
  }

  .pr-lg-0,
  .px-lg-0 {
    padding-right: 0 !important;
  }

  .pb-lg-0,
  .py-lg-0 {
    padding-bottom: 0 !important;
  }

  .pl-lg-0,
  .px-lg-0 {
    padding-left: 0 !important;
  }

  .p-lg-1 {
    padding: 0.25rem !important;
  }

  .pt-lg-1,
  .py-lg-1 {
    padding-top: 0.25rem !important;
  }

  .pr-lg-1,
  .px-lg-1 {
    padding-right: 0.25rem !important;
  }

  .pb-lg-1,
  .py-lg-1 {
    padding-bottom: 0.25rem !important;
  }

  .pl-lg-1,
  .px-lg-1 {
    padding-left: 0.25rem !important;
  }

  .p-lg-2 {
    padding: 0.5rem !important;
  }

  .pt-lg-2,
  .py-lg-2 {
    padding-top: 0.5rem !important;
  }

  .pr-lg-2,
  .px-lg-2 {
    padding-right: 0.5rem !important;
  }

  .pb-lg-2,
  .py-lg-2 {
    padding-bottom: 0.5rem !important;
  }

  .pl-lg-2,
  .px-lg-2 {
    padding-left: 0.5rem !important;
  }

  .p-lg-3 {
    padding: 1rem !important;
  }

  .pt-lg-3,
  .py-lg-3 {
    padding-top: 1rem !important;
  }

  .pr-lg-3,
  .px-lg-3 {
    padding-right: 1rem !important;
  }

  .pb-lg-3,
  .py-lg-3 {
    padding-bottom: 1rem !important;
  }

  .pl-lg-3,
  .px-lg-3 {
    padding-left: 1rem !important;
  }

  .p-lg-4 {
    padding: 1.5rem !important;
  }

  .pt-lg-4,
  .py-lg-4 {
    padding-top: 1.5rem !important;
  }

  .pr-lg-4,
  .px-lg-4 {
    padding-right: 1.5rem !important;
  }

  .pb-lg-4,
  .py-lg-4 {
    padding-bottom: 1.5rem !important;
  }

  .pl-lg-4,
  .px-lg-4 {
    padding-left: 1.5rem !important;
  }

  .p-lg-5 {
    padding: 3rem !important;
  }

  .pt-lg-5,
  .py-lg-5 {
    padding-top: 3rem !important;
  }

  .pr-lg-5,
  .px-lg-5 {
    padding-right: 3rem !important;
  }

  .pb-lg-5,
  .py-lg-5 {
    padding-bottom: 3rem !important;
  }

  .pl-lg-5,
  .px-lg-5 {
    padding-left: 3rem !important;
  }

  .m-lg-n1 {
    margin: -0.25rem !important;
  }

  .mt-lg-n1,
  .my-lg-n1 {
    margin-top: -0.25rem !important;
  }

  .mr-lg-n1,
  .mx-lg-n1 {
    margin-right: -0.25rem !important;
  }

  .mb-lg-n1,
  .my-lg-n1 {
    margin-bottom: -0.25rem !important;
  }

  .ml-lg-n1,
  .mx-lg-n1 {
    margin-left: -0.25rem !important;
  }

  .m-lg-n2 {
    margin: -0.5rem !important;
  }

  .mt-lg-n2,
  .my-lg-n2 {
    margin-top: -0.5rem !important;
  }

  .mr-lg-n2,
  .mx-lg-n2 {
    margin-right: -0.5rem !important;
  }

  .mb-lg-n2,
  .my-lg-n2 {
    margin-bottom: -0.5rem !important;
  }

  .ml-lg-n2,
  .mx-lg-n2 {
    margin-left: -0.5rem !important;
  }

  .m-lg-n3 {
    margin: -1rem !important;
  }

  .mt-lg-n3,
  .my-lg-n3 {
    margin-top: -1rem !important;
  }

  .mr-lg-n3,
  .mx-lg-n3 {
    margin-right: -1rem !important;
  }

  .mb-lg-n3,
  .my-lg-n3 {
    margin-bottom: -1rem !important;
  }

  .ml-lg-n3,
  .mx-lg-n3 {
    margin-left: -1rem !important;
  }

  .m-lg-n4 {
    margin: -1.5rem !important;
  }

  .mt-lg-n4,
  .my-lg-n4 {
    margin-top: -1.5rem !important;
  }

  .mr-lg-n4,
  .mx-lg-n4 {
    margin-right: -1.5rem !important;
  }

  .mb-lg-n4,
  .my-lg-n4 {
    margin-bottom: -1.5rem !important;
  }

  .ml-lg-n4,
  .mx-lg-n4 {
    margin-left: -1.5rem !important;
  }

  .m-lg-n5 {
    margin: -3rem !important;
  }

  .mt-lg-n5,
  .my-lg-n5 {
    margin-top: -3rem !important;
  }

  .mr-lg-n5,
  .mx-lg-n5 {
    margin-right: -3rem !important;
  }

  .mb-lg-n5,
  .my-lg-n5 {
    margin-bottom: -3rem !important;
  }

  .ml-lg-n5,
  .mx-lg-n5 {
    margin-left: -3rem !important;
  }

  .m-lg-auto {
    margin: auto !important;
  }

  .mt-lg-auto,
  .my-lg-auto {
    margin-top: auto !important;
  }

  .mr-lg-auto,
  .mx-lg-auto {
    margin-right: auto !important;
  }

  .mb-lg-auto,
  .my-lg-auto {
    margin-bottom: auto !important;
  }

  .ml-lg-auto,
  .mx-lg-auto {
    margin-left: auto !important;
  }
}

@media (min-width: 1200px) {
  .m-xl-0 {
    margin: 0 !important;
  }

  .mt-xl-0,
  .my-xl-0 {
    margin-top: 0 !important;
  }

  .mr-xl-0,
  .mx-xl-0 {
    margin-right: 0 !important;
  }

  .mb-xl-0,
  .my-xl-0 {
    margin-bottom: 0 !important;
  }

  .ml-xl-0,
  .mx-xl-0 {
    margin-left: 0 !important;
  }

  .m-xl-1 {
    margin: 0.25rem !important;
  }

  .mt-xl-1,
  .my-xl-1 {
    margin-top: 0.25rem !important;
  }

  .mr-xl-1,
  .mx-xl-1 {
    margin-right: 0.25rem !important;
  }

  .mb-xl-1,
  .my-xl-1 {
    margin-bottom: 0.25rem !important;
  }

  .ml-xl-1,
  .mx-xl-1 {
    margin-left: 0.25rem !important;
  }

  .m-xl-2 {
    margin: 0.5rem !important;
  }

  .mt-xl-2,
  .my-xl-2 {
    margin-top: 0.5rem !important;
  }

  .mr-xl-2,
  .mx-xl-2 {
    margin-right: 0.5rem !important;
  }

  .mb-xl-2,
  .my-xl-2 {
    margin-bottom: 0.5rem !important;
  }

  .ml-xl-2,
  .mx-xl-2 {
    margin-left: 0.5rem !important;
  }

  .m-xl-3 {
    margin: 1rem !important;
  }

  .mt-xl-3,
  .my-xl-3 {
    margin-top: 1rem !important;
  }

  .mr-xl-3,
  .mx-xl-3 {
    margin-right: 1rem !important;
  }

  .mb-xl-3,
  .my-xl-3 {
    margin-bottom: 1rem !important;
  }

  .ml-xl-3,
  .mx-xl-3 {
    margin-left: 1rem !important;
  }

  .m-xl-4 {
    margin: 1.5rem !important;
  }

  .mt-xl-4,
  .my-xl-4 {
    margin-top: 1.5rem !important;
  }

  .mr-xl-4,
  .mx-xl-4 {
    margin-right: 1.5rem !important;
  }

  .mb-xl-4,
  .my-xl-4 {
    margin-bottom: 1.5rem !important;
  }

  .ml-xl-4,
  .mx-xl-4 {
    margin-left: 1.5rem !important;
  }

  .m-xl-5 {
    margin: 3rem !important;
  }

  .mt-xl-5,
  .my-xl-5 {
    margin-top: 3rem !important;
  }

  .mr-xl-5,
  .mx-xl-5 {
    margin-right: 3rem !important;
  }

  .mb-xl-5,
  .my-xl-5 {
    margin-bottom: 3rem !important;
  }

  .ml-xl-5,
  .mx-xl-5 {
    margin-left: 3rem !important;
  }

  .p-xl-0 {
    padding: 0 !important;
  }

  .pt-xl-0,
  .py-xl-0 {
    padding-top: 0 !important;
  }

  .pr-xl-0,
  .px-xl-0 {
    padding-right: 0 !important;
  }

  .pb-xl-0,
  .py-xl-0 {
    padding-bottom: 0 !important;
  }

  .pl-xl-0,
  .px-xl-0 {
    padding-left: 0 !important;
  }

  .p-xl-1 {
    padding: 0.25rem !important;
  }

  .pt-xl-1,
  .py-xl-1 {
    padding-top: 0.25rem !important;
  }

  .pr-xl-1,
  .px-xl-1 {
    padding-right: 0.25rem !important;
  }

  .pb-xl-1,
  .py-xl-1 {
    padding-bottom: 0.25rem !important;
  }

  .pl-xl-1,
  .px-xl-1 {
    padding-left: 0.25rem !important;
  }

  .p-xl-2 {
    padding: 0.5rem !important;
  }

  .pt-xl-2,
  .py-xl-2 {
    padding-top: 0.5rem !important;
  }

  .pr-xl-2,
  .px-xl-2 {
    padding-right: 0.5rem !important;
  }

  .pb-xl-2,
  .py-xl-2 {
    padding-bottom: 0.5rem !important;
  }

  .pl-xl-2,
  .px-xl-2 {
    padding-left: 0.5rem !important;
  }

  .p-xl-3 {
    padding: 1rem !important;
  }

  .pt-xl-3,
  .py-xl-3 {
    padding-top: 1rem !important;
  }

  .pr-xl-3,
  .px-xl-3 {
    padding-right: 1rem !important;
  }

  .pb-xl-3,
  .py-xl-3 {
    padding-bottom: 1rem !important;
  }

  .pl-xl-3,
  .px-xl-3 {
    padding-left: 1rem !important;
  }

  .p-xl-4 {
    padding: 1.5rem !important;
  }

  .pt-xl-4,
  .py-xl-4 {
    padding-top: 1.5rem !important;
  }

  .pr-xl-4,
  .px-xl-4 {
    padding-right: 1.5rem !important;
  }

  .pb-xl-4,
  .py-xl-4 {
    padding-bottom: 1.5rem !important;
  }

  .pl-xl-4,
  .px-xl-4 {
    padding-left: 1.5rem !important;
  }

  .p-xl-5 {
    padding: 3rem !important;
  }

  .pt-xl-5,
  .py-xl-5 {
    padding-top: 3rem !important;
  }

  .pr-xl-5,
  .px-xl-5 {
    padding-right: 3rem !important;
  }

  .pb-xl-5,
  .py-xl-5 {
    padding-bottom: 3rem !important;
  }

  .pl-xl-5,
  .px-xl-5 {
    padding-left: 3rem !important;
  }

  .m-xl-n1 {
    margin: -0.25rem !important;
  }

  .mt-xl-n1,
  .my-xl-n1 {
    margin-top: -0.25rem !important;
  }

  .mr-xl-n1,
  .mx-xl-n1 {
    margin-right: -0.25rem !important;
  }

  .mb-xl-n1,
  .my-xl-n1 {
    margin-bottom: -0.25rem !important;
  }

  .ml-xl-n1,
  .mx-xl-n1 {
    margin-left: -0.25rem !important;
  }

  .m-xl-n2 {
    margin: -0.5rem !important;
  }

  .mt-xl-n2,
  .my-xl-n2 {
    margin-top: -0.5rem !important;
  }

  .mr-xl-n2,
  .mx-xl-n2 {
    margin-right: -0.5rem !important;
  }

  .mb-xl-n2,
  .my-xl-n2 {
    margin-bottom: -0.5rem !important;
  }

  .ml-xl-n2,
  .mx-xl-n2 {
    margin-left: -0.5rem !important;
  }

  .m-xl-n3 {
    margin: -1rem !important;
  }

  .mt-xl-n3,
  .my-xl-n3 {
    margin-top: -1rem !important;
  }

  .mr-xl-n3,
  .mx-xl-n3 {
    margin-right: -1rem !important;
  }

  .mb-xl-n3,
  .my-xl-n3 {
    margin-bottom: -1rem !important;
  }

  .ml-xl-n3,
  .mx-xl-n3 {
    margin-left: -1rem !important;
  }

  .m-xl-n4 {
    margin: -1.5rem !important;
  }

  .mt-xl-n4,
  .my-xl-n4 {
    margin-top: -1.5rem !important;
  }

  .mr-xl-n4,
  .mx-xl-n4 {
    margin-right: -1.5rem !important;
  }

  .mb-xl-n4,
  .my-xl-n4 {
    margin-bottom: -1.5rem !important;
  }

  .ml-xl-n4,
  .mx-xl-n4 {
    margin-left: -1.5rem !important;
  }

  .m-xl-n5 {
    margin: -3rem !important;
  }

  .mt-xl-n5,
  .my-xl-n5 {
    margin-top: -3rem !important;
  }

  .mr-xl-n5,
  .mx-xl-n5 {
    margin-right: -3rem !important;
  }

  .mb-xl-n5,
  .my-xl-n5 {
    margin-bottom: -3rem !important;
  }

  .ml-xl-n5,
  .mx-xl-n5 {
    margin-left: -3rem !important;
  }

  .m-xl-auto {
    margin: auto !important;
  }

  .mt-xl-auto,
  .my-xl-auto {
    margin-top: auto !important;
  }

  .mr-xl-auto,
  .mx-xl-auto {
    margin-right: auto !important;
  }

  .mb-xl-auto,
  .my-xl-auto {
    margin-bottom: auto !important;
  }

  .ml-xl-auto,
  .mx-xl-auto {
    margin-left: auto !important;
  }
}

.stretched-link::after {
  position: absolute;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1;
  pointer-events: auto;
  content: "";
  background-color: rgba(0, 0, 0, 0);
}

.text-monospace {
  font-family: SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace !important;
}

.text-justify {
  text-align: justify !important;
}

.text-wrap {
  white-space: normal !important;
}

.text-nowrap {
  white-space: nowrap !important;
}

.text-truncate {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}

.text-left {
  text-align: left !important;
}

.text-right {
  text-align: right !important;
}

.text-center {
  text-align: center !important;
}

@media (min-width: 576px) {
  .text-sm-left {
    text-align: left !important;
  }

  .text-sm-right {
    text-align: right !important;
  }

  .text-sm-center {
    text-align: center !important;
  }
}

@media (min-width: 768px) {
  .text-md-left {
    text-align: left !important;
  }

  .text-md-right {
    text-align: right !important;
  }

  .text-md-center {
    text-align: center !important;
  }
}

@media (min-width: 992px) {
  .text-lg-left {
    text-align: left !important;
  }

  .text-lg-right {
    text-align: right !important;
  }

  .text-lg-center {
    text-align: center !important;
  }
}

@media (min-width: 1200px) {
  .text-xl-left {
    text-align: left !important;
  }

  .text-xl-right {
    text-align: right !important;
  }

  .text-xl-center {
    text-align: center !important;
  }
}

.text-lowercase {
  text-transform: lowercase !important;
}

.text-uppercase {
  text-transform: uppercase !important;
}

.text-capitalize {
  text-transform: capitalize !important;
}

.font-weight-light {
  font-weight: 300 !important;
}

.font-weight-lighter {
  font-weight: lighter !important;
}

.font-weight-normal {
  font-weight: 400 !important;
}

.font-weight-bold {
  font-weight: 700 !important;
}

.font-weight-bolder {
  font-weight: bolder !important;
}

.font-italic {
  font-style: italic !important;
}

.text-white {
  color: #fff !important;
}

.text-primary {
  color: #3490dc !important;
}

a.text-primary:hover,
a.text-primary:focus {
  color: #1d68a7 !important;
}

.text-secondary {
  color: #6c757d !important;
}

a.text-secondary:hover,
a.text-secondary:focus {
  color: #494f54 !important;
}

.text-success {
  color: #38c172 !important;
}

a.text-success:hover,
a.text-success:focus {
  color: #27864f !important;
}

.text-info {
  color: #6cb2eb !important;
}

a.text-info:hover,
a.text-info:focus {
  color: #298fe2 !important;
}

.text-warning {
  color: #ffed4a !important;
}

a.text-warning:hover,
a.text-warning:focus {
  color: #fde300 !important;
}

.text-danger {
  color: #e3342f !important;
}

a.text-danger:hover,
a.text-danger:focus {
  color: #ae1c17 !important;
}

.text-light {
  color: #f8f9fa !important;
}

a.text-light:hover,
a.text-light:focus {
  color: #cbd3da !important;
}

.text-dark {
  color: #343a40 !important;
}

a.text-dark:hover,
a.text-dark:focus {
  color: #121416 !important;
}

.text-body {
  color: #212529 !important;
}

.text-muted {
  color: #6c757d !important;
}

.text-black-50 {
  color: rgba(0, 0, 0, 0.5) !important;
}

.text-white-50 {
  color: rgba(255, 255, 255, 0.5) !important;
}

.text-hide {
  font: 0/0 a;
  color: transparent;
  text-shadow: none;
  background-color: transparent;
  border: 0;
}

.text-decoration-none {
  text-decoration: none !important;
}

.text-break {
  word-break: break-word !important;
  word-wrap: break-word !important;
}

.text-reset {
  color: inherit !important;
}

.visible {
  visibility: visible !important;
}

.invisible {
  visibility: hidden !important;
}

@media print {
  *,
  *::before,
  *::after {
    text-shadow: none !important;
    box-shadow: none !important;
  }

  a:not(.btn) {
    text-decoration: underline;
  }

  abbr[title]::after {
    content: " (" attr(title) ")";
  }

  pre {
    white-space: pre-wrap !important;
  }

  pre,
  blockquote {
    border: 1px solid #adb5bd;
    page-break-inside: avoid;
  }

  thead {
    display: table-header-group;
  }

  tr,
  img {
    page-break-inside: avoid;
  }

  p,
  h2,
  h3 {
    orphans: 3;
    widows: 3;
  }

  h2,
  h3 {
    page-break-after: avoid;
  }

@page {
    size: a3;
}

  body {
    min-width: 992px !important;
  }

  .container {
    min-width: 992px !important;
  }

  .navbar {
    display: none;
  }

  .badge {
    border: 1px solid #000;
  }

  .table {
    border-collapse: collapse !important;
  }

  .table td,
  .table th {
    background-color: #fff !important;
  }

  .table-bordered th,
  .table-bordered td {
    border: 1px solid #dee2e6 !important;
  }

  .table-dark {
    color: inherit;
  }

  .table-dark th,
  .table-dark td,
  .table-dark thead th,
  .table-dark tbody + tbody {
    border-color: #dee2e6;
  }

  .table .thead-dark th {
    color: inherit;
    border-color: #dee2e6;
  }
}

/*!
 * Font Awesome Free 5.15.1 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */

.fa,
.fas,
.far,
.fal,
.fad,
.fab {
  -moz-osx-font-smoothing: grayscale;
  -webkit-font-smoothing: antialiased;
  display: inline-block;
  font-style: normal;
  font-variant: normal;
  text-rendering: auto;
  line-height: 1;
}

.fa-lg {
  font-size: 1.3333333333em;
  line-height: 0.75em;
  vertical-align: -0.0667em;
}

.fa-xs {
  font-size: 0.75em;
}

.fa-sm {
  font-size: 0.875em;
}

.fa-1x {
  font-size: 1em;
}

.fa-2x {
  font-size: 2em;
}

.fa-3x {
  font-size: 3em;
}

.fa-4x {
  font-size: 4em;
}

.fa-5x {
  font-size: 5em;
}

.fa-6x {
  font-size: 6em;
}

.fa-7x {
  font-size: 7em;
}

.fa-8x {
  font-size: 8em;
}

.fa-9x {
  font-size: 9em;
}

.fa-10x {
  font-size: 10em;
}

.fa-fw {
  text-align: center;
  width: 1.25em;
}

.fa-ul {
  list-style-type: none;
  margin-left: 2.5em;
  padding-left: 0;
}

.fa-ul > li {
  position: relative;
}

.fa-li {
  left: -2em;
  position: absolute;
  text-align: center;
  width: 2em;
  line-height: inherit;
}

.fa-border {
  border: solid 0.08em #eee;
  border-radius: 0.1em;
  padding: 0.2em 0.25em 0.15em;
}

.fa-pull-left {
  float: left;
}

.fa-pull-right {
  float: right;
}

.fa.fa-pull-left,
.fas.fa-pull-left,
.far.fa-pull-left,
.fal.fa-pull-left,
.fab.fa-pull-left {
  margin-right: 0.3em;
}

.fa.fa-pull-right,
.fas.fa-pull-right,
.far.fa-pull-right,
.fal.fa-pull-right,
.fab.fa-pull-right {
  margin-left: 0.3em;
}

.fa-spin {
  -webkit-animation: fa-spin 2s infinite linear;
          animation: fa-spin 2s infinite linear;
}

.fa-pulse {
  -webkit-animation: fa-spin 1s infinite steps(8);
          animation: fa-spin 1s infinite steps(8);
}

@-webkit-keyframes fa-spin {
  0% {
    transform: rotate(0deg);
  }

  100% {
    transform: rotate(360deg);
  }
}

@keyframes fa-spin {
  0% {
    transform: rotate(0deg);
  }

  100% {
    transform: rotate(360deg);
  }
}

.fa-rotate-90 {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=1)";
  transform: rotate(90deg);
}

.fa-rotate-180 {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=2)";
  transform: rotate(180deg);
}

.fa-rotate-270 {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=3)";
  transform: rotate(270deg);
}

.fa-flip-horizontal {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=0, mirror=1)";
  transform: scale(-1, 1);
}

.fa-flip-vertical {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1)";
  transform: scale(1, -1);
}

.fa-flip-both,
.fa-flip-horizontal.fa-flip-vertical {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1)";
  transform: scale(-1, -1);
}

:root .fa-rotate-90,
:root .fa-rotate-180,
:root .fa-rotate-270,
:root .fa-flip-horizontal,
:root .fa-flip-vertical,
:root .fa-flip-both {
  filter: none;
}

.fa-stack {
  display: inline-block;
  height: 2em;
  line-height: 2em;
  position: relative;
  vertical-align: middle;
  width: 2.5em;
}

.fa-stack-1x,
.fa-stack-2x {
  left: 0;
  position: absolute;
  text-align: center;
  width: 100%;
}

.fa-stack-1x {
  line-height: inherit;
}

.fa-stack-2x {
  font-size: 2em;
}

.fa-inverse {
  color: #fff;
}

/* Font Awesome uses the Unicode Private Use Area (PUA) to ensure screen
readers do not read off random characters that represent icons */

.fa-500px:before {
  content: "\F26E";
}

.fa-accessible-icon:before {
  content: "\F368";
}

.fa-accusoft:before {
  content: "\F369";
}

.fa-acquisitions-incorporated:before {
  content: "\F6AF";
}

.fa-ad:before {
  content: "\F641";
}

.fa-address-book:before {
  content: "\F2B9";
}

.fa-address-card:before {
  content: "\F2BB";
}

.fa-adjust:before {
  content: "\F042";
}

.fa-adn:before {
  content: "\F170";
}

.fa-adversal:before {
  content: "\F36A";
}

.fa-affiliatetheme:before {
  content: "\F36B";
}

.fa-air-freshener:before {
  content: "\F5D0";
}

.fa-airbnb:before {
  content: "\F834";
}

.fa-algolia:before {
  content: "\F36C";
}

.fa-align-center:before {
  content: "\F037";
}

.fa-align-justify:before {
  content: "\F039";
}

.fa-align-left:before {
  content: "\F036";
}

.fa-align-right:before {
  content: "\F038";
}

.fa-alipay:before {
  content: "\F642";
}

.fa-allergies:before {
  content: "\F461";
}

.fa-amazon:before {
  content: "\F270";
}

.fa-amazon-pay:before {
  content: "\F42C";
}

.fa-ambulance:before {
  content: "\F0F9";
}

.fa-american-sign-language-interpreting:before {
  content: "\F2A3";
}

.fa-amilia:before {
  content: "\F36D";
}

.fa-anchor:before {
  content: "\F13D";
}

.fa-android:before {
  content: "\F17B";
}

.fa-angellist:before {
  content: "\F209";
}

.fa-angle-double-down:before {
  content: "\F103";
}

.fa-angle-double-left:before {
  content: "\F100";
}

.fa-angle-double-right:before {
  content: "\F101";
}

.fa-angle-double-up:before {
  content: "\F102";
}

.fa-angle-down:before {
  content: "\F107";
}

.fa-angle-left:before {
  content: "\F104";
}

.fa-angle-right:before {
  content: "\F105";
}

.fa-angle-up:before {
  content: "\F106";
}

.fa-angry:before {
  content: "\F556";
}

.fa-angrycreative:before {
  content: "\F36E";
}

.fa-angular:before {
  content: "\F420";
}

.fa-ankh:before {
  content: "\F644";
}

.fa-app-store:before {
  content: "\F36F";
}

.fa-app-store-ios:before {
  content: "\F370";
}

.fa-apper:before {
  content: "\F371";
}

.fa-apple:before {
  content: "\F179";
}

.fa-apple-alt:before {
  content: "\F5D1";
}

.fa-apple-pay:before {
  content: "\F415";
}

.fa-archive:before {
  content: "\F187";
}

.fa-archway:before {
  content: "\F557";
}

.fa-arrow-alt-circle-down:before {
  content: "\F358";
}

.fa-arrow-alt-circle-left:before {
  content: "\F359";
}

.fa-arrow-alt-circle-right:before {
  content: "\F35A";
}

.fa-arrow-alt-circle-up:before {
  content: "\F35B";
}

.fa-arrow-circle-down:before {
  content: "\F0AB";
}

.fa-arrow-circle-left:before {
  content: "\F0A8";
}

.fa-arrow-circle-right:before {
  content: "\F0A9";
}

.fa-arrow-circle-up:before {
  content: "\F0AA";
}

.fa-arrow-down:before {
  content: "\F063";
}

.fa-arrow-left:before {
  content: "\F060";
}

.fa-arrow-right:before {
  content: "\F061";
}

.fa-arrow-up:before {
  content: "\F062";
}

.fa-arrows-alt:before {
  content: "\F0B2";
}

.fa-arrows-alt-h:before {
  content: "\F337";
}

.fa-arrows-alt-v:before {
  content: "\F338";
}

.fa-artstation:before {
  content: "\F77A";
}

.fa-assistive-listening-systems:before {
  content: "\F2A2";
}

.fa-asterisk:before {
  content: "\F069";
}

.fa-asymmetrik:before {
  content: "\F372";
}

.fa-at:before {
  content: "\F1FA";
}

.fa-atlas:before {
  content: "\F558";
}

.fa-atlassian:before {
  content: "\F77B";
}

.fa-atom:before {
  content: "\F5D2";
}

.fa-audible:before {
  content: "\F373";
}

.fa-audio-description:before {
  content: "\F29E";
}

.fa-autoprefixer:before {
  content: "\F41C";
}

.fa-avianex:before {
  content: "\F374";
}

.fa-aviato:before {
  content: "\F421";
}

.fa-award:before {
  content: "\F559";
}

.fa-aws:before {
  content: "\F375";
}

.fa-baby:before {
  content: "\F77C";
}

.fa-baby-carriage:before {
  content: "\F77D";
}

.fa-backspace:before {
  content: "\F55A";
}

.fa-backward:before {
  content: "\F04A";
}

.fa-bacon:before {
  content: "\F7E5";
}

.fa-bacteria:before {
  content: "\E059";
}

.fa-bacterium:before {
  content: "\E05A";
}

.fa-bahai:before {
  content: "\F666";
}

.fa-balance-scale:before {
  content: "\F24E";
}

.fa-balance-scale-left:before {
  content: "\F515";
}

.fa-balance-scale-right:before {
  content: "\F516";
}

.fa-ban:before {
  content: "\F05E";
}

.fa-band-aid:before {
  content: "\F462";
}

.fa-bandcamp:before {
  content: "\F2D5";
}

.fa-barcode:before {
  content: "\F02A";
}

.fa-bars:before {
  content: "\F0C9";
}

.fa-baseball-ball:before {
  content: "\F433";
}

.fa-basketball-ball:before {
  content: "\F434";
}

.fa-bath:before {
  content: "\F2CD";
}

.fa-battery-empty:before {
  content: "\F244";
}

.fa-battery-full:before {
  content: "\F240";
}

.fa-battery-half:before {
  content: "\F242";
}

.fa-battery-quarter:before {
  content: "\F243";
}

.fa-battery-three-quarters:before {
  content: "\F241";
}

.fa-battle-net:before {
  content: "\F835";
}

.fa-bed:before {
  content: "\F236";
}

.fa-beer:before {
  content: "\F0FC";
}

.fa-behance:before {
  content: "\F1B4";
}

.fa-behance-square:before {
  content: "\F1B5";
}

.fa-bell:before {
  content: "\F0F3";
}

.fa-bell-slash:before {
  content: "\F1F6";
}

.fa-bezier-curve:before {
  content: "\F55B";
}

.fa-bible:before {
  content: "\F647";
}

.fa-bicycle:before {
  content: "\F206";
}

.fa-biking:before {
  content: "\F84A";
}

.fa-bimobject:before {
  content: "\F378";
}

.fa-binoculars:before {
  content: "\F1E5";
}

.fa-biohazard:before {
  content: "\F780";
}

.fa-birthday-cake:before {
  content: "\F1FD";
}

.fa-bitbucket:before {
  content: "\F171";
}

.fa-bitcoin:before {
  content: "\F379";
}

.fa-bity:before {
  content: "\F37A";
}

.fa-black-tie:before {
  content: "\F27E";
}

.fa-blackberry:before {
  content: "\F37B";
}

.fa-blender:before {
  content: "\F517";
}

.fa-blender-phone:before {
  content: "\F6B6";
}

.fa-blind:before {
  content: "\F29D";
}

.fa-blog:before {
  content: "\F781";
}

.fa-blogger:before {
  content: "\F37C";
}

.fa-blogger-b:before {
  content: "\F37D";
}

.fa-bluetooth:before {
  content: "\F293";
}

.fa-bluetooth-b:before {
  content: "\F294";
}

.fa-bold:before {
  content: "\F032";
}

.fa-bolt:before {
  content: "\F0E7";
}

.fa-bomb:before {
  content: "\F1E2";
}

.fa-bone:before {
  content: "\F5D7";
}

.fa-bong:before {
  content: "\F55C";
}

.fa-book:before {
  content: "\F02D";
}

.fa-book-dead:before {
  content: "\F6B7";
}

.fa-book-medical:before {
  content: "\F7E6";
}

.fa-book-open:before {
  content: "\F518";
}

.fa-book-reader:before {
  content: "\F5DA";
}

.fa-bookmark:before {
  content: "\F02E";
}

.fa-bootstrap:before {
  content: "\F836";
}

.fa-border-all:before {
  content: "\F84C";
}

.fa-border-none:before {
  content: "\F850";
}

.fa-border-style:before {
  content: "\F853";
}

.fa-bowling-ball:before {
  content: "\F436";
}

.fa-box:before {
  content: "\F466";
}

.fa-box-open:before {
  content: "\F49E";
}

.fa-box-tissue:before {
  content: "\E05B";
}

.fa-boxes:before {
  content: "\F468";
}

.fa-braille:before {
  content: "\F2A1";
}

.fa-brain:before {
  content: "\F5DC";
}

.fa-bread-slice:before {
  content: "\F7EC";
}

.fa-briefcase:before {
  content: "\F0B1";
}

.fa-briefcase-medical:before {
  content: "\F469";
}

.fa-broadcast-tower:before {
  content: "\F519";
}

.fa-broom:before {
  content: "\F51A";
}

.fa-brush:before {
  content: "\F55D";
}

.fa-btc:before {
  content: "\F15A";
}

.fa-buffer:before {
  content: "\F837";
}

.fa-bug:before {
  content: "\F188";
}

.fa-building:before {
  content: "\F1AD";
}

.fa-bullhorn:before {
  content: "\F0A1";
}

.fa-bullseye:before {
  content: "\F140";
}

.fa-burn:before {
  content: "\F46A";
}

.fa-buromobelexperte:before {
  content: "\F37F";
}

.fa-bus:before {
  content: "\F207";
}

.fa-bus-alt:before {
  content: "\F55E";
}

.fa-business-time:before {
  content: "\F64A";
}

.fa-buy-n-large:before {
  content: "\F8A6";
}

.fa-buysellads:before {
  content: "\F20D";
}

.fa-calculator:before {
  content: "\F1EC";
}

.fa-calendar:before {
  content: "\F133";
}

.fa-calendar-alt:before {
  content: "\F073";
}

.fa-calendar-check:before {
  content: "\F274";
}

.fa-calendar-day:before {
  content: "\F783";
}

.fa-calendar-minus:before {
  content: "\F272";
}

.fa-calendar-plus:before {
  content: "\F271";
}

.fa-calendar-times:before {
  content: "\F273";
}

.fa-calendar-week:before {
  content: "\F784";
}

.fa-camera:before {
  content: "\F030";
}

.fa-camera-retro:before {
  content: "\F083";
}

.fa-campground:before {
  content: "\F6BB";
}

.fa-canadian-maple-leaf:before {
  content: "\F785";
}

.fa-candy-cane:before {
  content: "\F786";
}

.fa-cannabis:before {
  content: "\F55F";
}

.fa-capsules:before {
  content: "\F46B";
}

.fa-car:before {
  content: "\F1B9";
}

.fa-car-alt:before {
  content: "\F5DE";
}

.fa-car-battery:before {
  content: "\F5DF";
}

.fa-car-crash:before {
  content: "\F5E1";
}

.fa-car-side:before {
  content: "\F5E4";
}

.fa-caravan:before {
  content: "\F8FF";
}

.fa-caret-down:before {
  content: "\F0D7";
}

.fa-caret-left:before {
  content: "\F0D9";
}

.fa-caret-right:before {
  content: "\F0DA";
}

.fa-caret-square-down:before {
  content: "\F150";
}

.fa-caret-square-left:before {
  content: "\F191";
}

.fa-caret-square-right:before {
  content: "\F152";
}

.fa-caret-square-up:before {
  content: "\F151";
}

.fa-caret-up:before {
  content: "\F0D8";
}

.fa-carrot:before {
  content: "\F787";
}

.fa-cart-arrow-down:before {
  content: "\F218";
}

.fa-cart-plus:before {
  content: "\F217";
}

.fa-cash-register:before {
  content: "\F788";
}

.fa-cat:before {
  content: "\F6BE";
}

.fa-cc-amazon-pay:before {
  content: "\F42D";
}

.fa-cc-amex:before {
  content: "\F1F3";
}

.fa-cc-apple-pay:before {
  content: "\F416";
}

.fa-cc-diners-club:before {
  content: "\F24C";
}

.fa-cc-discover:before {
  content: "\F1F2";
}

.fa-cc-jcb:before {
  content: "\F24B";
}

.fa-cc-mastercard:before {
  content: "\F1F1";
}

.fa-cc-paypal:before {
  content: "\F1F4";
}

.fa-cc-stripe:before {
  content: "\F1F5";
}

.fa-cc-visa:before {
  content: "\F1F0";
}

.fa-centercode:before {
  content: "\F380";
}

.fa-centos:before {
  content: "\F789";
}

.fa-certificate:before {
  content: "\F0A3";
}

.fa-chair:before {
  content: "\F6C0";
}

.fa-chalkboard:before {
  content: "\F51B";
}

.fa-chalkboard-teacher:before {
  content: "\F51C";
}

.fa-charging-station:before {
  content: "\F5E7";
}

.fa-chart-area:before {
  content: "\F1FE";
}

.fa-chart-bar:before {
  content: "\F080";
}

.fa-chart-line:before {
  content: "\F201";
}

.fa-chart-pie:before {
  content: "\F200";
}

.fa-check:before {
  content: "\F00C";
}

.fa-check-circle:before {
  content: "\F058";
}

.fa-check-double:before {
  content: "\F560";
}

.fa-check-square:before {
  content: "\F14A";
}

.fa-cheese:before {
  content: "\F7EF";
}

.fa-chess:before {
  content: "\F439";
}

.fa-chess-bishop:before {
  content: "\F43A";
}

.fa-chess-board:before {
  content: "\F43C";
}

.fa-chess-king:before {
  content: "\F43F";
}

.fa-chess-knight:before {
  content: "\F441";
}

.fa-chess-pawn:before {
  content: "\F443";
}

.fa-chess-queen:before {
  content: "\F445";
}

.fa-chess-rook:before {
  content: "\F447";
}

.fa-chevron-circle-down:before {
  content: "\F13A";
}

.fa-chevron-circle-left:before {
  content: "\F137";
}

.fa-chevron-circle-right:before {
  content: "\F138";
}

.fa-chevron-circle-up:before {
  content: "\F139";
}

.fa-chevron-down:before {
  content: "\F078";
}

.fa-chevron-left:before {
  content: "\F053";
}

.fa-chevron-right:before {
  content: "\F054";
}

.fa-chevron-up:before {
  content: "\F077";
}

.fa-child:before {
  content: "\F1AE";
}

.fa-chrome:before {
  content: "\F268";
}

.fa-chromecast:before {
  content: "\F838";
}

.fa-church:before {
  content: "\F51D";
}

.fa-circle:before {
  content: "\F111";
}

.fa-circle-notch:before {
  content: "\F1CE";
}

.fa-city:before {
  content: "\F64F";
}

.fa-clinic-medical:before {
  content: "\F7F2";
}

.fa-clipboard:before {
  content: "\F328";
}

.fa-clipboard-check:before {
  content: "\F46C";
}

.fa-clipboard-list:before {
  content: "\F46D";
}

.fa-clock:before {
  content: "\F017";
}

.fa-clone:before {
  content: "\F24D";
}

.fa-closed-captioning:before {
  content: "\F20A";
}

.fa-cloud:before {
  content: "\F0C2";
}

.fa-cloud-download-alt:before {
  content: "\F381";
}

.fa-cloud-meatball:before {
  content: "\F73B";
}

.fa-cloud-moon:before {
  content: "\F6C3";
}

.fa-cloud-moon-rain:before {
  content: "\F73C";
}

.fa-cloud-rain:before {
  content: "\F73D";
}

.fa-cloud-showers-heavy:before {
  content: "\F740";
}

.fa-cloud-sun:before {
  content: "\F6C4";
}

.fa-cloud-sun-rain:before {
  content: "\F743";
}

.fa-cloud-upload-alt:before {
  content: "\F382";
}

.fa-cloudflare:before {
  content: "\E07D";
}

.fa-cloudscale:before {
  content: "\F383";
}

.fa-cloudsmith:before {
  content: "\F384";
}

.fa-cloudversify:before {
  content: "\F385";
}

.fa-cocktail:before {
  content: "\F561";
}

.fa-code:before {
  content: "\F121";
}

.fa-code-branch:before {
  content: "\F126";
}

.fa-codepen:before {
  content: "\F1CB";
}

.fa-codiepie:before {
  content: "\F284";
}

.fa-coffee:before {
  content: "\F0F4";
}

.fa-cog:before {
  content: "\F013";
}

.fa-cogs:before {
  content: "\F085";
}

.fa-coins:before {
  content: "\F51E";
}

.fa-columns:before {
  content: "\F0DB";
}

.fa-comment:before {
  content: "\F075";
}

.fa-comment-alt:before {
  content: "\F27A";
}

.fa-comment-dollar:before {
  content: "\F651";
}

.fa-comment-dots:before {
  content: "\F4AD";
}

.fa-comment-medical:before {
  content: "\F7F5";
}

.fa-comment-slash:before {
  content: "\F4B3";
}

.fa-comments:before {
  content: "\F086";
}

.fa-comments-dollar:before {
  content: "\F653";
}

.fa-compact-disc:before {
  content: "\F51F";
}

.fa-compass:before {
  content: "\F14E";
}

.fa-compress:before {
  content: "\F066";
}

.fa-compress-alt:before {
  content: "\F422";
}

.fa-compress-arrows-alt:before {
  content: "\F78C";
}

.fa-concierge-bell:before {
  content: "\F562";
}

.fa-confluence:before {
  content: "\F78D";
}

.fa-connectdevelop:before {
  content: "\F20E";
}

.fa-contao:before {
  content: "\F26D";
}

.fa-cookie:before {
  content: "\F563";
}

.fa-cookie-bite:before {
  content: "\F564";
}

.fa-copy:before {
  content: "\F0C5";
}

.fa-copyright:before {
  content: "\F1F9";
}

.fa-cotton-bureau:before {
  content: "\F89E";
}

.fa-couch:before {
  content: "\F4B8";
}

.fa-cpanel:before {
  content: "\F388";
}

.fa-creative-commons:before {
  content: "\F25E";
}

.fa-creative-commons-by:before {
  content: "\F4E7";
}

.fa-creative-commons-nc:before {
  content: "\F4E8";
}

.fa-creative-commons-nc-eu:before {
  content: "\F4E9";
}

.fa-creative-commons-nc-jp:before {
  content: "\F4EA";
}

.fa-creative-commons-nd:before {
  content: "\F4EB";
}

.fa-creative-commons-pd:before {
  content: "\F4EC";
}

.fa-creative-commons-pd-alt:before {
  content: "\F4ED";
}

.fa-creative-commons-remix:before {
  content: "\F4EE";
}

.fa-creative-commons-sa:before {
  content: "\F4EF";
}

.fa-creative-commons-sampling:before {
  content: "\F4F0";
}

.fa-creative-commons-sampling-plus:before {
  content: "\F4F1";
}

.fa-creative-commons-share:before {
  content: "\F4F2";
}

.fa-creative-commons-zero:before {
  content: "\F4F3";
}

.fa-credit-card:before {
  content: "\F09D";
}

.fa-critical-role:before {
  content: "\F6C9";
}

.fa-crop:before {
  content: "\F125";
}

.fa-crop-alt:before {
  content: "\F565";
}

.fa-cross:before {
  content: "\F654";
}

.fa-crosshairs:before {
  content: "\F05B";
}

.fa-crow:before {
  content: "\F520";
}

.fa-crown:before {
  content: "\F521";
}

.fa-crutch:before {
  content: "\F7F7";
}

.fa-css3:before {
  content: "\F13C";
}

.fa-css3-alt:before {
  content: "\F38B";
}

.fa-cube:before {
  content: "\F1B2";
}

.fa-cubes:before {
  content: "\F1B3";
}

.fa-cut:before {
  content: "\F0C4";
}

.fa-cuttlefish:before {
  content: "\F38C";
}

.fa-d-and-d:before {
  content: "\F38D";
}

.fa-d-and-d-beyond:before {
  content: "\F6CA";
}

.fa-dailymotion:before {
  content: "\E052";
}

.fa-dashcube:before {
  content: "\F210";
}

.fa-database:before {
  content: "\F1C0";
}

.fa-deaf:before {
  content: "\F2A4";
}

.fa-deezer:before {
  content: "\E077";
}

.fa-delicious:before {
  content: "\F1A5";
}

.fa-democrat:before {
  content: "\F747";
}

.fa-deploydog:before {
  content: "\F38E";
}

.fa-deskpro:before {
  content: "\F38F";
}

.fa-desktop:before {
  content: "\F108";
}

.fa-dev:before {
  content: "\F6CC";
}

.fa-deviantart:before {
  content: "\F1BD";
}

.fa-dharmachakra:before {
  content: "\F655";
}

.fa-dhl:before {
  content: "\F790";
}

.fa-diagnoses:before {
  content: "\F470";
}

.fa-diaspora:before {
  content: "\F791";
}

.fa-dice:before {
  content: "\F522";
}

.fa-dice-d20:before {
  content: "\F6CF";
}

.fa-dice-d6:before {
  content: "\F6D1";
}

.fa-dice-five:before {
  content: "\F523";
}

.fa-dice-four:before {
  content: "\F524";
}

.fa-dice-one:before {
  content: "\F525";
}

.fa-dice-six:before {
  content: "\F526";
}

.fa-dice-three:before {
  content: "\F527";
}

.fa-dice-two:before {
  content: "\F528";
}

.fa-digg:before {
  content: "\F1A6";
}

.fa-digital-ocean:before {
  content: "\F391";
}

.fa-digital-tachograph:before {
  content: "\F566";
}

.fa-directions:before {
  content: "\F5EB";
}

.fa-discord:before {
  content: "\F392";
}

.fa-discourse:before {
  content: "\F393";
}

.fa-disease:before {
  content: "\F7FA";
}

.fa-divide:before {
  content: "\F529";
}

.fa-dizzy:before {
  content: "\F567";
}

.fa-dna:before {
  content: "\F471";
}

.fa-dochub:before {
  content: "\F394";
}

.fa-docker:before {
  content: "\F395";
}

.fa-dog:before {
  content: "\F6D3";
}

.fa-dollar-sign:before {
  content: "\F155";
}

.fa-dolly:before {
  content: "\F472";
}

.fa-dolly-flatbed:before {
  content: "\F474";
}

.fa-donate:before {
  content: "\F4B9";
}

.fa-door-closed:before {
  content: "\F52A";
}

.fa-door-open:before {
  content: "\F52B";
}

.fa-dot-circle:before {
  content: "\F192";
}

.fa-dove:before {
  content: "\F4BA";
}

.fa-download:before {
  content: "\F019";
}

.fa-draft2digital:before {
  content: "\F396";
}

.fa-drafting-compass:before {
  content: "\F568";
}

.fa-dragon:before {
  content: "\F6D5";
}

.fa-draw-polygon:before {
  content: "\F5EE";
}

.fa-dribbble:before {
  content: "\F17D";
}

.fa-dribbble-square:before {
  content: "\F397";
}

.fa-dropbox:before {
  content: "\F16B";
}

.fa-drum:before {
  content: "\F569";
}

.fa-drum-steelpan:before {
  content: "\F56A";
}

.fa-drumstick-bite:before {
  content: "\F6D7";
}

.fa-drupal:before {
  content: "\F1A9";
}

.fa-dumbbell:before {
  content: "\F44B";
}

.fa-dumpster:before {
  content: "\F793";
}

.fa-dumpster-fire:before {
  content: "\F794";
}

.fa-dungeon:before {
  content: "\F6D9";
}

.fa-dyalog:before {
  content: "\F399";
}

.fa-earlybirds:before {
  content: "\F39A";
}

.fa-ebay:before {
  content: "\F4F4";
}

.fa-edge:before {
  content: "\F282";
}

.fa-edge-legacy:before {
  content: "\E078";
}

.fa-edit:before {
  content: "\F044";
}

.fa-egg:before {
  content: "\F7FB";
}

.fa-eject:before {
  content: "\F052";
}

.fa-elementor:before {
  content: "\F430";
}

.fa-ellipsis-h:before {
  content: "\F141";
}

.fa-ellipsis-v:before {
  content: "\F142";
}

.fa-ello:before {
  content: "\F5F1";
}

.fa-ember:before {
  content: "\F423";
}

.fa-empire:before {
  content: "\F1D1";
}

.fa-envelope:before {
  content: "\F0E0";
}

.fa-envelope-open:before {
  content: "\F2B6";
}

.fa-envelope-open-text:before {
  content: "\F658";
}

.fa-envelope-square:before {
  content: "\F199";
}

.fa-envira:before {
  content: "\F299";
}

.fa-equals:before {
  content: "\F52C";
}

.fa-eraser:before {
  content: "\F12D";
}

.fa-erlang:before {
  content: "\F39D";
}

.fa-ethereum:before {
  content: "\F42E";
}

.fa-ethernet:before {
  content: "\F796";
}

.fa-etsy:before {
  content: "\F2D7";
}

.fa-euro-sign:before {
  content: "\F153";
}

.fa-evernote:before {
  content: "\F839";
}

.fa-exchange-alt:before {
  content: "\F362";
}

.fa-exclamation:before {
  content: "\F12A";
}

.fa-exclamation-circle:before {
  content: "\F06A";
}

.fa-exclamation-triangle:before {
  content: "\F071";
}

.fa-expand:before {
  content: "\F065";
}

.fa-expand-alt:before {
  content: "\F424";
}

.fa-expand-arrows-alt:before {
  content: "\F31E";
}

.fa-expeditedssl:before {
  content: "\F23E";
}

.fa-external-link-alt:before {
  content: "\F35D";
}

.fa-external-link-square-alt:before {
  content: "\F360";
}

.fa-eye:before {
  content: "\F06E";
}

.fa-eye-dropper:before {
  content: "\F1FB";
}

.fa-eye-slash:before {
  content: "\F070";
}

.fa-facebook:before {
  content: "\F09A";
}

.fa-facebook-f:before {
  content: "\F39E";
}

.fa-facebook-messenger:before {
  content: "\F39F";
}

.fa-facebook-square:before {
  content: "\F082";
}

.fa-fan:before {
  content: "\F863";
}

.fa-fantasy-flight-games:before {
  content: "\F6DC";
}

.fa-fast-backward:before {
  content: "\F049";
}

.fa-fast-forward:before {
  content: "\F050";
}

.fa-faucet:before {
  content: "\E005";
}

.fa-fax:before {
  content: "\F1AC";
}

.fa-feather:before {
  content: "\F52D";
}

.fa-feather-alt:before {
  content: "\F56B";
}

.fa-fedex:before {
  content: "\F797";
}

.fa-fedora:before {
  content: "\F798";
}

.fa-female:before {
  content: "\F182";
}

.fa-fighter-jet:before {
  content: "\F0FB";
}

.fa-figma:before {
  content: "\F799";
}

.fa-file:before {
  content: "\F15B";
}

.fa-file-alt:before {
  content: "\F15C";
}

.fa-file-archive:before {
  content: "\F1C6";
}

.fa-file-audio:before {
  content: "\F1C7";
}

.fa-file-code:before {
  content: "\F1C9";
}

.fa-file-contract:before {
  content: "\F56C";
}

.fa-file-csv:before {
  content: "\F6DD";
}

.fa-file-download:before {
  content: "\F56D";
}

.fa-file-excel:before {
  content: "\F1C3";
}

.fa-file-export:before {
  content: "\F56E";
}

.fa-file-image:before {
  content: "\F1C5";
}

.fa-file-import:before {
  content: "\F56F";
}

.fa-file-invoice:before {
  content: "\F570";
}

.fa-file-invoice-dollar:before {
  content: "\F571";
}

.fa-file-medical:before {
  content: "\F477";
}

.fa-file-medical-alt:before {
  content: "\F478";
}

.fa-file-pdf:before {
  content: "\F1C1";
}

.fa-file-powerpoint:before {
  content: "\F1C4";
}

.fa-file-prescription:before {
  content: "\F572";
}

.fa-file-signature:before {
  content: "\F573";
}

.fa-file-upload:before {
  content: "\F574";
}

.fa-file-video:before {
  content: "\F1C8";
}

.fa-file-word:before {
  content: "\F1C2";
}

.fa-fill:before {
  content: "\F575";
}

.fa-fill-drip:before {
  content: "\F576";
}

.fa-film:before {
  content: "\F008";
}

.fa-filter:before {
  content: "\F0B0";
}

.fa-fingerprint:before {
  content: "\F577";
}

.fa-fire:before {
  content: "\F06D";
}

.fa-fire-alt:before {
  content: "\F7E4";
}

.fa-fire-extinguisher:before {
  content: "\F134";
}

.fa-firefox:before {
  content: "\F269";
}

.fa-firefox-browser:before {
  content: "\E007";
}

.fa-first-aid:before {
  content: "\F479";
}

.fa-first-order:before {
  content: "\F2B0";
}

.fa-first-order-alt:before {
  content: "\F50A";
}

.fa-firstdraft:before {
  content: "\F3A1";
}

.fa-fish:before {
  content: "\F578";
}

.fa-fist-raised:before {
  content: "\F6DE";
}

.fa-flag:before {
  content: "\F024";
}

.fa-flag-checkered:before {
  content: "\F11E";
}

.fa-flag-usa:before {
  content: "\F74D";
}

.fa-flask:before {
  content: "\F0C3";
}

.fa-flickr:before {
  content: "\F16E";
}

.fa-flipboard:before {
  content: "\F44D";
}

.fa-flushed:before {
  content: "\F579";
}

.fa-fly:before {
  content: "\F417";
}

.fa-folder:before {
  content: "\F07B";
}

.fa-folder-minus:before {
  content: "\F65D";
}

.fa-folder-open:before {
  content: "\F07C";
}

.fa-folder-plus:before {
  content: "\F65E";
}

.fa-font:before {
  content: "\F031";
}

.fa-font-awesome:before {
  content: "\F2B4";
}

.fa-font-awesome-alt:before {
  content: "\F35C";
}

.fa-font-awesome-flag:before {
  content: "\F425";
}

.fa-font-awesome-logo-full:before {
  content: "\F4E6";
}

.fa-fonticons:before {
  content: "\F280";
}

.fa-fonticons-fi:before {
  content: "\F3A2";
}

.fa-football-ball:before {
  content: "\F44E";
}

.fa-fort-awesome:before {
  content: "\F286";
}

.fa-fort-awesome-alt:before {
  content: "\F3A3";
}

.fa-forumbee:before {
  content: "\F211";
}

.fa-forward:before {
  content: "\F04E";
}

.fa-foursquare:before {
  content: "\F180";
}

.fa-free-code-camp:before {
  content: "\F2C5";
}

.fa-freebsd:before {
  content: "\F3A4";
}

.fa-frog:before {
  content: "\F52E";
}

.fa-frown:before {
  content: "\F119";
}

.fa-frown-open:before {
  content: "\F57A";
}

.fa-fulcrum:before {
  content: "\F50B";
}

.fa-funnel-dollar:before {
  content: "\F662";
}

.fa-futbol:before {
  content: "\F1E3";
}

.fa-galactic-republic:before {
  content: "\F50C";
}

.fa-galactic-senate:before {
  content: "\F50D";
}

.fa-gamepad:before {
  content: "\F11B";
}

.fa-gas-pump:before {
  content: "\F52F";
}

.fa-gavel:before {
  content: "\F0E3";
}

.fa-gem:before {
  content: "\F3A5";
}

.fa-genderless:before {
  content: "\F22D";
}

.fa-get-pocket:before {
  content: "\F265";
}

.fa-gg:before {
  content: "\F260";
}

.fa-gg-circle:before {
  content: "\F261";
}

.fa-ghost:before {
  content: "\F6E2";
}

.fa-gift:before {
  content: "\F06B";
}

.fa-gifts:before {
  content: "\F79C";
}

.fa-git:before {
  content: "\F1D3";
}

.fa-git-alt:before {
  content: "\F841";
}

.fa-git-square:before {
  content: "\F1D2";
}

.fa-github:before {
  content: "\F09B";
}

.fa-github-alt:before {
  content: "\F113";
}

.fa-github-square:before {
  content: "\F092";
}

.fa-gitkraken:before {
  content: "\F3A6";
}

.fa-gitlab:before {
  content: "\F296";
}

.fa-gitter:before {
  content: "\F426";
}

.fa-glass-cheers:before {
  content: "\F79F";
}

.fa-glass-martini:before {
  content: "\F000";
}

.fa-glass-martini-alt:before {
  content: "\F57B";
}

.fa-glass-whiskey:before {
  content: "\F7A0";
}

.fa-glasses:before {
  content: "\F530";
}

.fa-glide:before {
  content: "\F2A5";
}

.fa-glide-g:before {
  content: "\F2A6";
}

.fa-globe:before {
  content: "\F0AC";
}

.fa-globe-africa:before {
  content: "\F57C";
}

.fa-globe-americas:before {
  content: "\F57D";
}

.fa-globe-asia:before {
  content: "\F57E";
}

.fa-globe-europe:before {
  content: "\F7A2";
}

.fa-gofore:before {
  content: "\F3A7";
}

.fa-golf-ball:before {
  content: "\F450";
}

.fa-goodreads:before {
  content: "\F3A8";
}

.fa-goodreads-g:before {
  content: "\F3A9";
}

.fa-google:before {
  content: "\F1A0";
}

.fa-google-drive:before {
  content: "\F3AA";
}

.fa-google-pay:before {
  content: "\E079";
}

.fa-google-play:before {
  content: "\F3AB";
}

.fa-google-plus:before {
  content: "\F2B3";
}

.fa-google-plus-g:before {
  content: "\F0D5";
}

.fa-google-plus-square:before {
  content: "\F0D4";
}

.fa-google-wallet:before {
  content: "\F1EE";
}

.fa-gopuram:before {
  content: "\F664";
}

.fa-graduation-cap:before {
  content: "\F19D";
}

.fa-gratipay:before {
  content: "\F184";
}

.fa-grav:before {
  content: "\F2D6";
}

.fa-greater-than:before {
  content: "\F531";
}

.fa-greater-than-equal:before {
  content: "\F532";
}

.fa-grimace:before {
  content: "\F57F";
}

.fa-grin:before {
  content: "\F580";
}

.fa-grin-alt:before {
  content: "\F581";
}

.fa-grin-beam:before {
  content: "\F582";
}

.fa-grin-beam-sweat:before {
  content: "\F583";
}

.fa-grin-hearts:before {
  content: "\F584";
}

.fa-grin-squint:before {
  content: "\F585";
}

.fa-grin-squint-tears:before {
  content: "\F586";
}

.fa-grin-stars:before {
  content: "\F587";
}

.fa-grin-tears:before {
  content: "\F588";
}

.fa-grin-tongue:before {
  content: "\F589";
}

.fa-grin-tongue-squint:before {
  content: "\F58A";
}

.fa-grin-tongue-wink:before {
  content: "\F58B";
}

.fa-grin-wink:before {
  content: "\F58C";
}

.fa-grip-horizontal:before {
  content: "\F58D";
}

.fa-grip-lines:before {
  content: "\F7A4";
}

.fa-grip-lines-vertical:before {
  content: "\F7A5";
}

.fa-grip-vertical:before {
  content: "\F58E";
}

.fa-gripfire:before {
  content: "\F3AC";
}

.fa-grunt:before {
  content: "\F3AD";
}

.fa-guilded:before {
  content: "\E07E";
}

.fa-guitar:before {
  content: "\F7A6";
}

.fa-gulp:before {
  content: "\F3AE";
}

.fa-h-square:before {
  content: "\F0FD";
}

.fa-hacker-news:before {
  content: "\F1D4";
}

.fa-hacker-news-square:before {
  content: "\F3AF";
}

.fa-hackerrank:before {
  content: "\F5F7";
}

.fa-hamburger:before {
  content: "\F805";
}

.fa-hammer:before {
  content: "\F6E3";
}

.fa-hamsa:before {
  content: "\F665";
}

.fa-hand-holding:before {
  content: "\F4BD";
}

.fa-hand-holding-heart:before {
  content: "\F4BE";
}

.fa-hand-holding-medical:before {
  content: "\E05C";
}

.fa-hand-holding-usd:before {
  content: "\F4C0";
}

.fa-hand-holding-water:before {
  content: "\F4C1";
}

.fa-hand-lizard:before {
  content: "\F258";
}

.fa-hand-middle-finger:before {
  content: "\F806";
}

.fa-hand-paper:before {
  content: "\F256";
}

.fa-hand-peace:before {
  content: "\F25B";
}

.fa-hand-point-down:before {
  content: "\F0A7";
}

.fa-hand-point-left:before {
  content: "\F0A5";
}

.fa-hand-point-right:before {
  content: "\F0A4";
}

.fa-hand-point-up:before {
  content: "\F0A6";
}

.fa-hand-pointer:before {
  content: "\F25A";
}

.fa-hand-rock:before {
  content: "\F255";
}

.fa-hand-scissors:before {
  content: "\F257";
}

.fa-hand-sparkles:before {
  content: "\E05D";
}

.fa-hand-spock:before {
  content: "\F259";
}

.fa-hands:before {
  content: "\F4C2";
}

.fa-hands-helping:before {
  content: "\F4C4";
}

.fa-hands-wash:before {
  content: "\E05E";
}

.fa-handshake:before {
  content: "\F2B5";
}

.fa-handshake-alt-slash:before {
  content: "\E05F";
}

.fa-handshake-slash:before {
  content: "\E060";
}

.fa-hanukiah:before {
  content: "\F6E6";
}

.fa-hard-hat:before {
  content: "\F807";
}

.fa-hashtag:before {
  content: "\F292";
}

.fa-hat-cowboy:before {
  content: "\F8C0";
}

.fa-hat-cowboy-side:before {
  content: "\F8C1";
}

.fa-hat-wizard:before {
  content: "\F6E8";
}

.fa-hdd:before {
  content: "\F0A0";
}

.fa-head-side-cough:before {
  content: "\E061";
}

.fa-head-side-cough-slash:before {
  content: "\E062";
}

.fa-head-side-mask:before {
  content: "\E063";
}

.fa-head-side-virus:before {
  content: "\E064";
}

.fa-heading:before {
  content: "\F1DC";
}

.fa-headphones:before {
  content: "\F025";
}

.fa-headphones-alt:before {
  content: "\F58F";
}

.fa-headset:before {
  content: "\F590";
}

.fa-heart:before {
  content: "\F004";
}

.fa-heart-broken:before {
  content: "\F7A9";
}

.fa-heartbeat:before {
  content: "\F21E";
}

.fa-helicopter:before {
  content: "\F533";
}

.fa-highlighter:before {
  content: "\F591";
}

.fa-hiking:before {
  content: "\F6EC";
}

.fa-hippo:before {
  content: "\F6ED";
}

.fa-hips:before {
  content: "\F452";
}

.fa-hire-a-helper:before {
  content: "\F3B0";
}

.fa-history:before {
  content: "\F1DA";
}

.fa-hive:before {
  content: "\E07F";
}

.fa-hockey-puck:before {
  content: "\F453";
}

.fa-holly-berry:before {
  content: "\F7AA";
}

.fa-home:before {
  content: "\F015";
}

.fa-hooli:before {
  content: "\F427";
}

.fa-hornbill:before {
  content: "\F592";
}

.fa-horse:before {
  content: "\F6F0";
}

.fa-horse-head:before {
  content: "\F7AB";
}

.fa-hospital:before {
  content: "\F0F8";
}

.fa-hospital-alt:before {
  content: "\F47D";
}

.fa-hospital-symbol:before {
  content: "\F47E";
}

.fa-hospital-user:before {
  content: "\F80D";
}

.fa-hot-tub:before {
  content: "\F593";
}

.fa-hotdog:before {
  content: "\F80F";
}

.fa-hotel:before {
  content: "\F594";
}

.fa-hotjar:before {
  content: "\F3B1";
}

.fa-hourglass:before {
  content: "\F254";
}

.fa-hourglass-end:before {
  content: "\F253";
}

.fa-hourglass-half:before {
  content: "\F252";
}

.fa-hourglass-start:before {
  content: "\F251";
}

.fa-house-damage:before {
  content: "\F6F1";
}

.fa-house-user:before {
  content: "\E065";
}

.fa-houzz:before {
  content: "\F27C";
}

.fa-hryvnia:before {
  content: "\F6F2";
}

.fa-html5:before {
  content: "\F13B";
}

.fa-hubspot:before {
  content: "\F3B2";
}

.fa-i-cursor:before {
  content: "\F246";
}

.fa-ice-cream:before {
  content: "\F810";
}

.fa-icicles:before {
  content: "\F7AD";
}

.fa-icons:before {
  content: "\F86D";
}

.fa-id-badge:before {
  content: "\F2C1";
}

.fa-id-card:before {
  content: "\F2C2";
}

.fa-id-card-alt:before {
  content: "\F47F";
}

.fa-ideal:before {
  content: "\E013";
}

.fa-igloo:before {
  content: "\F7AE";
}

.fa-image:before {
  content: "\F03E";
}

.fa-images:before {
  content: "\F302";
}

.fa-imdb:before {
  content: "\F2D8";
}

.fa-inbox:before {
  content: "\F01C";
}

.fa-indent:before {
  content: "\F03C";
}

.fa-industry:before {
  content: "\F275";
}

.fa-infinity:before {
  content: "\F534";
}

.fa-info:before {
  content: "\F129";
}

.fa-info-circle:before {
  content: "\F05A";
}

.fa-innosoft:before {
  content: "\E080";
}

.fa-instagram:before {
  content: "\F16D";
}

.fa-instagram-square:before {
  content: "\E055";
}

.fa-instalod:before {
  content: "\E081";
}

.fa-intercom:before {
  content: "\F7AF";
}

.fa-internet-explorer:before {
  content: "\F26B";
}

.fa-invision:before {
  content: "\F7B0";
}

.fa-ioxhost:before {
  content: "\F208";
}

.fa-italic:before {
  content: "\F033";
}

.fa-itch-io:before {
  content: "\F83A";
}

.fa-itunes:before {
  content: "\F3B4";
}

.fa-itunes-note:before {
  content: "\F3B5";
}

.fa-java:before {
  content: "\F4E4";
}

.fa-jedi:before {
  content: "\F669";
}

.fa-jedi-order:before {
  content: "\F50E";
}

.fa-jenkins:before {
  content: "\F3B6";
}

.fa-jira:before {
  content: "\F7B1";
}

.fa-joget:before {
  content: "\F3B7";
}

.fa-joint:before {
  content: "\F595";
}

.fa-joomla:before {
  content: "\F1AA";
}

.fa-journal-whills:before {
  content: "\F66A";
}

.fa-js:before {
  content: "\F3B8";
}

.fa-js-square:before {
  content: "\F3B9";
}

.fa-jsfiddle:before {
  content: "\F1CC";
}

.fa-kaaba:before {
  content: "\F66B";
}

.fa-kaggle:before {
  content: "\F5FA";
}

.fa-key:before {
  content: "\F084";
}

.fa-keybase:before {
  content: "\F4F5";
}

.fa-keyboard:before {
  content: "\F11C";
}

.fa-keycdn:before {
  content: "\F3BA";
}

.fa-khanda:before {
  content: "\F66D";
}

.fa-kickstarter:before {
  content: "\F3BB";
}

.fa-kickstarter-k:before {
  content: "\F3BC";
}

.fa-kiss:before {
  content: "\F596";
}

.fa-kiss-beam:before {
  content: "\F597";
}

.fa-kiss-wink-heart:before {
  content: "\F598";
}

.fa-kiwi-bird:before {
  content: "\F535";
}

.fa-korvue:before {
  content: "\F42F";
}

.fa-landmark:before {
  content: "\F66F";
}

.fa-language:before {
  content: "\F1AB";
}

.fa-laptop:before {
  content: "\F109";
}

.fa-laptop-code:before {
  content: "\F5FC";
}

.fa-laptop-house:before {
  content: "\E066";
}

.fa-laptop-medical:before {
  content: "\F812";
}

.fa-laravel:before {
  content: "\F3BD";
}

.fa-lastfm:before {
  content: "\F202";
}

.fa-lastfm-square:before {
  content: "\F203";
}

.fa-laugh:before {
  content: "\F599";
}

.fa-laugh-beam:before {
  content: "\F59A";
}

.fa-laugh-squint:before {
  content: "\F59B";
}

.fa-laugh-wink:before {
  content: "\F59C";
}

.fa-layer-group:before {
  content: "\F5FD";
}

.fa-leaf:before {
  content: "\F06C";
}

.fa-leanpub:before {
  content: "\F212";
}

.fa-lemon:before {
  content: "\F094";
}

.fa-less:before {
  content: "\F41D";
}

.fa-less-than:before {
  content: "\F536";
}

.fa-less-than-equal:before {
  content: "\F537";
}

.fa-level-down-alt:before {
  content: "\F3BE";
}

.fa-level-up-alt:before {
  content: "\F3BF";
}

.fa-life-ring:before {
  content: "\F1CD";
}

.fa-lightbulb:before {
  content: "\F0EB";
}

.fa-line:before {
  content: "\F3C0";
}

.fa-link:before {
  content: "\F0C1";
}

.fa-linkedin:before {
  content: "\F08C";
}

.fa-linkedin-in:before {
  content: "\F0E1";
}

.fa-linode:before {
  content: "\F2B8";
}

.fa-linux:before {
  content: "\F17C";
}

.fa-lira-sign:before {
  content: "\F195";
}

.fa-list:before {
  content: "\F03A";
}

.fa-list-alt:before {
  content: "\F022";
}

.fa-list-ol:before {
  content: "\F0CB";
}

.fa-list-ul:before {
  content: "\F0CA";
}

.fa-location-arrow:before {
  content: "\F124";
}

.fa-lock:before {
  content: "\F023";
}

.fa-lock-open:before {
  content: "\F3C1";
}

.fa-long-arrow-alt-down:before {
  content: "\F309";
}

.fa-long-arrow-alt-left:before {
  content: "\F30A";
}

.fa-long-arrow-alt-right:before {
  content: "\F30B";
}

.fa-long-arrow-alt-up:before {
  content: "\F30C";
}

.fa-low-vision:before {
  content: "\F2A8";
}

.fa-luggage-cart:before {
  content: "\F59D";
}

.fa-lungs:before {
  content: "\F604";
}

.fa-lungs-virus:before {
  content: "\E067";
}

.fa-lyft:before {
  content: "\F3C3";
}

.fa-magento:before {
  content: "\F3C4";
}

.fa-magic:before {
  content: "\F0D0";
}

.fa-magnet:before {
  content: "\F076";
}

.fa-mail-bulk:before {
  content: "\F674";
}

.fa-mailchimp:before {
  content: "\F59E";
}

.fa-male:before {
  content: "\F183";
}

.fa-mandalorian:before {
  content: "\F50F";
}

.fa-map:before {
  content: "\F279";
}

.fa-map-marked:before {
  content: "\F59F";
}

.fa-map-marked-alt:before {
  content: "\F5A0";
}

.fa-map-marker:before {
  content: "\F041";
}

.fa-map-marker-alt:before {
  content: "\F3C5";
}

.fa-map-pin:before {
  content: "\F276";
}

.fa-map-signs:before {
  content: "\F277";
}

.fa-markdown:before {
  content: "\F60F";
}

.fa-marker:before {
  content: "\F5A1";
}

.fa-mars:before {
  content: "\F222";
}

.fa-mars-double:before {
  content: "\F227";
}

.fa-mars-stroke:before {
  content: "\F229";
}

.fa-mars-stroke-h:before {
  content: "\F22B";
}

.fa-mars-stroke-v:before {
  content: "\F22A";
}

.fa-mask:before {
  content: "\F6FA";
}

.fa-mastodon:before {
  content: "\F4F6";
}

.fa-maxcdn:before {
  content: "\F136";
}

.fa-mdb:before {
  content: "\F8CA";
}

.fa-medal:before {
  content: "\F5A2";
}

.fa-medapps:before {
  content: "\F3C6";
}

.fa-medium:before {
  content: "\F23A";
}

.fa-medium-m:before {
  content: "\F3C7";
}

.fa-medkit:before {
  content: "\F0FA";
}

.fa-medrt:before {
  content: "\F3C8";
}

.fa-meetup:before {
  content: "\F2E0";
}

.fa-megaport:before {
  content: "\F5A3";
}

.fa-meh:before {
  content: "\F11A";
}

.fa-meh-blank:before {
  content: "\F5A4";
}

.fa-meh-rolling-eyes:before {
  content: "\F5A5";
}

.fa-memory:before {
  content: "\F538";
}

.fa-mendeley:before {
  content: "\F7B3";
}

.fa-menorah:before {
  content: "\F676";
}

.fa-mercury:before {
  content: "\F223";
}

.fa-meteor:before {
  content: "\F753";
}

.fa-microblog:before {
  content: "\E01A";
}

.fa-microchip:before {
  content: "\F2DB";
}

.fa-microphone:before {
  content: "\F130";
}

.fa-microphone-alt:before {
  content: "\F3C9";
}

.fa-microphone-alt-slash:before {
  content: "\F539";
}

.fa-microphone-slash:before {
  content: "\F131";
}

.fa-microscope:before {
  content: "\F610";
}

.fa-microsoft:before {
  content: "\F3CA";
}

.fa-minus:before {
  content: "\F068";
}

.fa-minus-circle:before {
  content: "\F056";
}

.fa-minus-square:before {
  content: "\F146";
}

.fa-mitten:before {
  content: "\F7B5";
}

.fa-mix:before {
  content: "\F3CB";
}

.fa-mixcloud:before {
  content: "\F289";
}

.fa-mixer:before {
  content: "\E056";
}

.fa-mizuni:before {
  content: "\F3CC";
}

.fa-mobile:before {
  content: "\F10B";
}

.fa-mobile-alt:before {
  content: "\F3CD";
}

.fa-modx:before {
  content: "\F285";
}

.fa-monero:before {
  content: "\F3D0";
}

.fa-money-bill:before {
  content: "\F0D6";
}

.fa-money-bill-alt:before {
  content: "\F3D1";
}

.fa-money-bill-wave:before {
  content: "\F53A";
}

.fa-money-bill-wave-alt:before {
  content: "\F53B";
}

.fa-money-check:before {
  content: "\F53C";
}

.fa-money-check-alt:before {
  content: "\F53D";
}

.fa-monument:before {
  content: "\F5A6";
}

.fa-moon:before {
  content: "\F186";
}

.fa-mortar-pestle:before {
  content: "\F5A7";
}

.fa-mosque:before {
  content: "\F678";
}

.fa-motorcycle:before {
  content: "\F21C";
}

.fa-mountain:before {
  content: "\F6FC";
}

.fa-mouse:before {
  content: "\F8CC";
}

.fa-mouse-pointer:before {
  content: "\F245";
}

.fa-mug-hot:before {
  content: "\F7B6";
}

.fa-music:before {
  content: "\F001";
}

.fa-napster:before {
  content: "\F3D2";
}

.fa-neos:before {
  content: "\F612";
}

.fa-network-wired:before {
  content: "\F6FF";
}

.fa-neuter:before {
  content: "\F22C";
}

.fa-newspaper:before {
  content: "\F1EA";
}

.fa-nimblr:before {
  content: "\F5A8";
}

.fa-node:before {
  content: "\F419";
}

.fa-node-js:before {
  content: "\F3D3";
}

.fa-not-equal:before {
  content: "\F53E";
}

.fa-notes-medical:before {
  content: "\F481";
}

.fa-npm:before {
  content: "\F3D4";
}

.fa-ns8:before {
  content: "\F3D5";
}

.fa-nutritionix:before {
  content: "\F3D6";
}

.fa-object-group:before {
  content: "\F247";
}

.fa-object-ungroup:before {
  content: "\F248";
}

.fa-octopus-deploy:before {
  content: "\E082";
}

.fa-odnoklassniki:before {
  content: "\F263";
}

.fa-odnoklassniki-square:before {
  content: "\F264";
}

.fa-oil-can:before {
  content: "\F613";
}

.fa-old-republic:before {
  content: "\F510";
}

.fa-om:before {
  content: "\F679";
}

.fa-opencart:before {
  content: "\F23D";
}

.fa-openid:before {
  content: "\F19B";
}

.fa-opera:before {
  content: "\F26A";
}

.fa-optin-monster:before {
  content: "\F23C";
}

.fa-orcid:before {
  content: "\F8D2";
}

.fa-osi:before {
  content: "\F41A";
}

.fa-otter:before {
  content: "\F700";
}

.fa-outdent:before {
  content: "\F03B";
}

.fa-page4:before {
  content: "\F3D7";
}

.fa-pagelines:before {
  content: "\F18C";
}

.fa-pager:before {
  content: "\F815";
}

.fa-paint-brush:before {
  content: "\F1FC";
}

.fa-paint-roller:before {
  content: "\F5AA";
}

.fa-palette:before {
  content: "\F53F";
}

.fa-palfed:before {
  content: "\F3D8";
}

.fa-pallet:before {
  content: "\F482";
}

.fa-paper-plane:before {
  content: "\F1D8";
}

.fa-paperclip:before {
  content: "\F0C6";
}

.fa-parachute-box:before {
  content: "\F4CD";
}

.fa-paragraph:before {
  content: "\F1DD";
}

.fa-parking:before {
  content: "\F540";
}

.fa-passport:before {
  content: "\F5AB";
}

.fa-pastafarianism:before {
  content: "\F67B";
}

.fa-paste:before {
  content: "\F0EA";
}

.fa-patreon:before {
  content: "\F3D9";
}

.fa-pause:before {
  content: "\F04C";
}

.fa-pause-circle:before {
  content: "\F28B";
}

.fa-paw:before {
  content: "\F1B0";
}

.fa-paypal:before {
  content: "\F1ED";
}

.fa-peace:before {
  content: "\F67C";
}

.fa-pen:before {
  content: "\F304";
}

.fa-pen-alt:before {
  content: "\F305";
}

.fa-pen-fancy:before {
  content: "\F5AC";
}

.fa-pen-nib:before {
  content: "\F5AD";
}

.fa-pen-square:before {
  content: "\F14B";
}

.fa-pencil-alt:before {
  content: "\F303";
}

.fa-pencil-ruler:before {
  content: "\F5AE";
}

.fa-penny-arcade:before {
  content: "\F704";
}

.fa-people-arrows:before {
  content: "\E068";
}

.fa-people-carry:before {
  content: "\F4CE";
}

.fa-pepper-hot:before {
  content: "\F816";
}

.fa-perbyte:before {
  content: "\E083";
}

.fa-percent:before {
  content: "\F295";
}

.fa-percentage:before {
  content: "\F541";
}

.fa-periscope:before {
  content: "\F3DA";
}

.fa-person-booth:before {
  content: "\F756";
}

.fa-phabricator:before {
  content: "\F3DB";
}

.fa-phoenix-framework:before {
  content: "\F3DC";
}

.fa-phoenix-squadron:before {
  content: "\F511";
}

.fa-phone:before {
  content: "\F095";
}

.fa-phone-alt:before {
  content: "\F879";
}

.fa-phone-slash:before {
  content: "\F3DD";
}

.fa-phone-square:before {
  content: "\F098";
}

.fa-phone-square-alt:before {
  content: "\F87B";
}

.fa-phone-volume:before {
  content: "\F2A0";
}

.fa-photo-video:before {
  content: "\F87C";
}

.fa-php:before {
  content: "\F457";
}

.fa-pied-piper:before {
  content: "\F2AE";
}

.fa-pied-piper-alt:before {
  content: "\F1A8";
}

.fa-pied-piper-hat:before {
  content: "\F4E5";
}

.fa-pied-piper-pp:before {
  content: "\F1A7";
}

.fa-pied-piper-square:before {
  content: "\E01E";
}

.fa-piggy-bank:before {
  content: "\F4D3";
}

.fa-pills:before {
  content: "\F484";
}

.fa-pinterest:before {
  content: "\F0D2";
}

.fa-pinterest-p:before {
  content: "\F231";
}

.fa-pinterest-square:before {
  content: "\F0D3";
}

.fa-pizza-slice:before {
  content: "\F818";
}

.fa-place-of-worship:before {
  content: "\F67F";
}

.fa-plane:before {
  content: "\F072";
}

.fa-plane-arrival:before {
  content: "\F5AF";
}

.fa-plane-departure:before {
  content: "\F5B0";
}

.fa-plane-slash:before {
  content: "\E069";
}

.fa-play:before {
  content: "\F04B";
}

.fa-play-circle:before {
  content: "\F144";
}

.fa-playstation:before {
  content: "\F3DF";
}

.fa-plug:before {
  content: "\F1E6";
}

.fa-plus:before {
  content: "\F067";
}

.fa-plus-circle:before {
  content: "\F055";
}

.fa-plus-square:before {
  content: "\F0FE";
}

.fa-podcast:before {
  content: "\F2CE";
}

.fa-poll:before {
  content: "\F681";
}

.fa-poll-h:before {
  content: "\F682";
}

.fa-poo:before {
  content: "\F2FE";
}

.fa-poo-storm:before {
  content: "\F75A";
}

.fa-poop:before {
  content: "\F619";
}

.fa-portrait:before {
  content: "\F3E0";
}

.fa-pound-sign:before {
  content: "\F154";
}

.fa-power-off:before {
  content: "\F011";
}

.fa-pray:before {
  content: "\F683";
}

.fa-praying-hands:before {
  content: "\F684";
}

.fa-prescription:before {
  content: "\F5B1";
}

.fa-prescription-bottle:before {
  content: "\F485";
}

.fa-prescription-bottle-alt:before {
  content: "\F486";
}

.fa-print:before {
  content: "\F02F";
}

.fa-procedures:before {
  content: "\F487";
}

.fa-product-hunt:before {
  content: "\F288";
}

.fa-project-diagram:before {
  content: "\F542";
}

.fa-pump-medical:before {
  content: "\E06A";
}

.fa-pump-soap:before {
  content: "\E06B";
}

.fa-pushed:before {
  content: "\F3E1";
}

.fa-puzzle-piece:before {
  content: "\F12E";
}

.fa-python:before {
  content: "\F3E2";
}

.fa-qq:before {
  content: "\F1D6";
}

.fa-qrcode:before {
  content: "\F029";
}

.fa-question:before {
  content: "\F128";
}

.fa-question-circle:before {
  content: "\F059";
}

.fa-quidditch:before {
  content: "\F458";
}

.fa-quinscape:before {
  content: "\F459";
}

.fa-quora:before {
  content: "\F2C4";
}

.fa-quote-left:before {
  content: "\F10D";
}

.fa-quote-right:before {
  content: "\F10E";
}

.fa-quran:before {
  content: "\F687";
}

.fa-r-project:before {
  content: "\F4F7";
}

.fa-radiation:before {
  content: "\F7B9";
}

.fa-radiation-alt:before {
  content: "\F7BA";
}

.fa-rainbow:before {
  content: "\F75B";
}

.fa-random:before {
  content: "\F074";
}

.fa-raspberry-pi:before {
  content: "\F7BB";
}

.fa-ravelry:before {
  content: "\F2D9";
}

.fa-react:before {
  content: "\F41B";
}

.fa-reacteurope:before {
  content: "\F75D";
}

.fa-readme:before {
  content: "\F4D5";
}

.fa-rebel:before {
  content: "\F1D0";
}

.fa-receipt:before {
  content: "\F543";
}

.fa-record-vinyl:before {
  content: "\F8D9";
}

.fa-recycle:before {
  content: "\F1B8";
}

.fa-red-river:before {
  content: "\F3E3";
}

.fa-reddit:before {
  content: "\F1A1";
}

.fa-reddit-alien:before {
  content: "\F281";
}

.fa-reddit-square:before {
  content: "\F1A2";
}

.fa-redhat:before {
  content: "\F7BC";
}

.fa-redo:before {
  content: "\F01E";
}

.fa-redo-alt:before {
  content: "\F2F9";
}

.fa-registered:before {
  content: "\F25D";
}

.fa-remove-format:before {
  content: "\F87D";
}

.fa-renren:before {
  content: "\F18B";
}

.fa-reply:before {
  content: "\F3E5";
}

.fa-reply-all:before {
  content: "\F122";
}

.fa-replyd:before {
  content: "\F3E6";
}

.fa-republican:before {
  content: "\F75E";
}

.fa-researchgate:before {
  content: "\F4F8";
}

.fa-resolving:before {
  content: "\F3E7";
}

.fa-restroom:before {
  content: "\F7BD";
}

.fa-retweet:before {
  content: "\F079";
}

.fa-rev:before {
  content: "\F5B2";
}

.fa-ribbon:before {
  content: "\F4D6";
}

.fa-ring:before {
  content: "\F70B";
}

.fa-road:before {
  content: "\F018";
}

.fa-robot:before {
  content: "\F544";
}

.fa-rocket:before {
  content: "\F135";
}

.fa-rocketchat:before {
  content: "\F3E8";
}

.fa-rockrms:before {
  content: "\F3E9";
}

.fa-route:before {
  content: "\F4D7";
}

.fa-rss:before {
  content: "\F09E";
}

.fa-rss-square:before {
  content: "\F143";
}

.fa-ruble-sign:before {
  content: "\F158";
}

.fa-ruler:before {
  content: "\F545";
}

.fa-ruler-combined:before {
  content: "\F546";
}

.fa-ruler-horizontal:before {
  content: "\F547";
}

.fa-ruler-vertical:before {
  content: "\F548";
}

.fa-running:before {
  content: "\F70C";
}

.fa-rupee-sign:before {
  content: "\F156";
}

.fa-rust:before {
  content: "\E07A";
}

.fa-sad-cry:before {
  content: "\F5B3";
}

.fa-sad-tear:before {
  content: "\F5B4";
}

.fa-safari:before {
  content: "\F267";
}

.fa-salesforce:before {
  content: "\F83B";
}

.fa-sass:before {
  content: "\F41E";
}

.fa-satellite:before {
  content: "\F7BF";
}

.fa-satellite-dish:before {
  content: "\F7C0";
}

.fa-save:before {
  content: "\F0C7";
}

.fa-schlix:before {
  content: "\F3EA";
}

.fa-school:before {
  content: "\F549";
}

.fa-screwdriver:before {
  content: "\F54A";
}

.fa-scribd:before {
  content: "\F28A";
}

.fa-scroll:before {
  content: "\F70E";
}

.fa-sd-card:before {
  content: "\F7C2";
}

.fa-search:before {
  content: "\F002";
}

.fa-search-dollar:before {
  content: "\F688";
}

.fa-search-location:before {
  content: "\F689";
}

.fa-search-minus:before {
  content: "\F010";
}

.fa-search-plus:before {
  content: "\F00E";
}

.fa-searchengin:before {
  content: "\F3EB";
}

.fa-seedling:before {
  content: "\F4D8";
}

.fa-sellcast:before {
  content: "\F2DA";
}

.fa-sellsy:before {
  content: "\F213";
}

.fa-server:before {
  content: "\F233";
}

.fa-servicestack:before {
  content: "\F3EC";
}

.fa-shapes:before {
  content: "\F61F";
}

.fa-share:before {
  content: "\F064";
}

.fa-share-alt:before {
  content: "\F1E0";
}

.fa-share-alt-square:before {
  content: "\F1E1";
}

.fa-share-square:before {
  content: "\F14D";
}

.fa-shekel-sign:before {
  content: "\F20B";
}

.fa-shield-alt:before {
  content: "\F3ED";
}

.fa-shield-virus:before {
  content: "\E06C";
}

.fa-ship:before {
  content: "\F21A";
}

.fa-shipping-fast:before {
  content: "\F48B";
}

.fa-shirtsinbulk:before {
  content: "\F214";
}

.fa-shoe-prints:before {
  content: "\F54B";
}

.fa-shopify:before {
  content: "\E057";
}

.fa-shopping-bag:before {
  content: "\F290";
}

.fa-shopping-basket:before {
  content: "\F291";
}

.fa-shopping-cart:before {
  content: "\F07A";
}

.fa-shopware:before {
  content: "\F5B5";
}

.fa-shower:before {
  content: "\F2CC";
}

.fa-shuttle-van:before {
  content: "\F5B6";
}

.fa-sign:before {
  content: "\F4D9";
}

.fa-sign-in-alt:before {
  content: "\F2F6";
}

.fa-sign-language:before {
  content: "\F2A7";
}

.fa-sign-out-alt:before {
  content: "\F2F5";
}

.fa-signal:before {
  content: "\F012";
}

.fa-signature:before {
  content: "\F5B7";
}

.fa-sim-card:before {
  content: "\F7C4";
}

.fa-simplybuilt:before {
  content: "\F215";
}

.fa-sink:before {
  content: "\E06D";
}

.fa-sistrix:before {
  content: "\F3EE";
}

.fa-sitemap:before {
  content: "\F0E8";
}

.fa-sith:before {
  content: "\F512";
}

.fa-skating:before {
  content: "\F7C5";
}

.fa-sketch:before {
  content: "\F7C6";
}

.fa-skiing:before {
  content: "\F7C9";
}

.fa-skiing-nordic:before {
  content: "\F7CA";
}

.fa-skull:before {
  content: "\F54C";
}

.fa-skull-crossbones:before {
  content: "\F714";
}

.fa-skyatlas:before {
  content: "\F216";
}

.fa-skype:before {
  content: "\F17E";
}

.fa-slack:before {
  content: "\F198";
}

.fa-slack-hash:before {
  content: "\F3EF";
}

.fa-slash:before {
  content: "\F715";
}

.fa-sleigh:before {
  content: "\F7CC";
}

.fa-sliders-h:before {
  content: "\F1DE";
}

.fa-slideshare:before {
  content: "\F1E7";
}

.fa-smile:before {
  content: "\F118";
}

.fa-smile-beam:before {
  content: "\F5B8";
}

.fa-smile-wink:before {
  content: "\F4DA";
}

.fa-smog:before {
  content: "\F75F";
}

.fa-smoking:before {
  content: "\F48D";
}

.fa-smoking-ban:before {
  content: "\F54D";
}

.fa-sms:before {
  content: "\F7CD";
}

.fa-snapchat:before {
  content: "\F2AB";
}

.fa-snapchat-ghost:before {
  content: "\F2AC";
}

.fa-snapchat-square:before {
  content: "\F2AD";
}

.fa-snowboarding:before {
  content: "\F7CE";
}

.fa-snowflake:before {
  content: "\F2DC";
}

.fa-snowman:before {
  content: "\F7D0";
}

.fa-snowplow:before {
  content: "\F7D2";
}

.fa-soap:before {
  content: "\E06E";
}

.fa-socks:before {
  content: "\F696";
}

.fa-solar-panel:before {
  content: "\F5BA";
}

.fa-sort:before {
  content: "\F0DC";
}

.fa-sort-alpha-down:before {
  content: "\F15D";
}

.fa-sort-alpha-down-alt:before {
  content: "\F881";
}

.fa-sort-alpha-up:before {
  content: "\F15E";
}

.fa-sort-alpha-up-alt:before {
  content: "\F882";
}

.fa-sort-amount-down:before {
  content: "\F160";
}

.fa-sort-amount-down-alt:before {
  content: "\F884";
}

.fa-sort-amount-up:before {
  content: "\F161";
}

.fa-sort-amount-up-alt:before {
  content: "\F885";
}

.fa-sort-down:before {
  content: "\F0DD";
}

.fa-sort-numeric-down:before {
  content: "\F162";
}

.fa-sort-numeric-down-alt:before {
  content: "\F886";
}

.fa-sort-numeric-up:before {
  content: "\F163";
}

.fa-sort-numeric-up-alt:before {
  content: "\F887";
}

.fa-sort-up:before {
  content: "\F0DE";
}

.fa-soundcloud:before {
  content: "\F1BE";
}

.fa-sourcetree:before {
  content: "\F7D3";
}

.fa-spa:before {
  content: "\F5BB";
}

.fa-space-shuttle:before {
  content: "\F197";
}

.fa-speakap:before {
  content: "\F3F3";
}

.fa-speaker-deck:before {
  content: "\F83C";
}

.fa-spell-check:before {
  content: "\F891";
}

.fa-spider:before {
  content: "\F717";
}

.fa-spinner:before {
  content: "\F110";
}

.fa-splotch:before {
  content: "\F5BC";
}

.fa-spotify:before {
  content: "\F1BC";
}

.fa-spray-can:before {
  content: "\F5BD";
}

.fa-square:before {
  content: "\F0C8";
}

.fa-square-full:before {
  content: "\F45C";
}

.fa-square-root-alt:before {
  content: "\F698";
}

.fa-squarespace:before {
  content: "\F5BE";
}

.fa-stack-exchange:before {
  content: "\F18D";
}

.fa-stack-overflow:before {
  content: "\F16C";
}

.fa-stackpath:before {
  content: "\F842";
}

.fa-stamp:before {
  content: "\F5BF";
}

.fa-star:before {
  content: "\F005";
}

.fa-star-and-crescent:before {
  content: "\F699";
}

.fa-star-half:before {
  content: "\F089";
}

.fa-star-half-alt:before {
  content: "\F5C0";
}

.fa-star-of-david:before {
  content: "\F69A";
}

.fa-star-of-life:before {
  content: "\F621";
}

.fa-staylinked:before {
  content: "\F3F5";
}

.fa-steam:before {
  content: "\F1B6";
}

.fa-steam-square:before {
  content: "\F1B7";
}

.fa-steam-symbol:before {
  content: "\F3F6";
}

.fa-step-backward:before {
  content: "\F048";
}

.fa-step-forward:before {
  content: "\F051";
}

.fa-stethoscope:before {
  content: "\F0F1";
}

.fa-sticker-mule:before {
  content: "\F3F7";
}

.fa-sticky-note:before {
  content: "\F249";
}

.fa-stop:before {
  content: "\F04D";
}

.fa-stop-circle:before {
  content: "\F28D";
}

.fa-stopwatch:before {
  content: "\F2F2";
}

.fa-stopwatch-20:before {
  content: "\E06F";
}

.fa-store:before {
  content: "\F54E";
}

.fa-store-alt:before {
  content: "\F54F";
}

.fa-store-alt-slash:before {
  content: "\E070";
}

.fa-store-slash:before {
  content: "\E071";
}

.fa-strava:before {
  content: "\F428";
}

.fa-stream:before {
  content: "\F550";
}

.fa-street-view:before {
  content: "\F21D";
}

.fa-strikethrough:before {
  content: "\F0CC";
}

.fa-stripe:before {
  content: "\F429";
}

.fa-stripe-s:before {
  content: "\F42A";
}

.fa-stroopwafel:before {
  content: "\F551";
}

.fa-studiovinari:before {
  content: "\F3F8";
}

.fa-stumbleupon:before {
  content: "\F1A4";
}

.fa-stumbleupon-circle:before {
  content: "\F1A3";
}

.fa-subscript:before {
  content: "\F12C";
}

.fa-subway:before {
  content: "\F239";
}

.fa-suitcase:before {
  content: "\F0F2";
}

.fa-suitcase-rolling:before {
  content: "\F5C1";
}

.fa-sun:before {
  content: "\F185";
}

.fa-superpowers:before {
  content: "\F2DD";
}

.fa-superscript:before {
  content: "\F12B";
}

.fa-supple:before {
  content: "\F3F9";
}

.fa-surprise:before {
  content: "\F5C2";
}

.fa-suse:before {
  content: "\F7D6";
}

.fa-swatchbook:before {
  content: "\F5C3";
}

.fa-swift:before {
  content: "\F8E1";
}

.fa-swimmer:before {
  content: "\F5C4";
}

.fa-swimming-pool:before {
  content: "\F5C5";
}

.fa-symfony:before {
  content: "\F83D";
}

.fa-synagogue:before {
  content: "\F69B";
}

.fa-sync:before {
  content: "\F021";
}

.fa-sync-alt:before {
  content: "\F2F1";
}

.fa-syringe:before {
  content: "\F48E";
}

.fa-table:before {
  content: "\F0CE";
}

.fa-table-tennis:before {
  content: "\F45D";
}

.fa-tablet:before {
  content: "\F10A";
}

.fa-tablet-alt:before {
  content: "\F3FA";
}

.fa-tablets:before {
  content: "\F490";
}

.fa-tachometer-alt:before {
  content: "\F3FD";
}

.fa-tag:before {
  content: "\F02B";
}

.fa-tags:before {
  content: "\F02C";
}

.fa-tape:before {
  content: "\F4DB";
}

.fa-tasks:before {
  content: "\F0AE";
}

.fa-taxi:before {
  content: "\F1BA";
}

.fa-teamspeak:before {
  content: "\F4F9";
}

.fa-teeth:before {
  content: "\F62E";
}

.fa-teeth-open:before {
  content: "\F62F";
}

.fa-telegram:before {
  content: "\F2C6";
}

.fa-telegram-plane:before {
  content: "\F3FE";
}

.fa-temperature-high:before {
  content: "\F769";
}

.fa-temperature-low:before {
  content: "\F76B";
}

.fa-tencent-weibo:before {
  content: "\F1D5";
}

.fa-tenge:before {
  content: "\F7D7";
}

.fa-terminal:before {
  content: "\F120";
}

.fa-text-height:before {
  content: "\F034";
}

.fa-text-width:before {
  content: "\F035";
}

.fa-th:before {
  content: "\F00A";
}

.fa-th-large:before {
  content: "\F009";
}

.fa-th-list:before {
  content: "\F00B";
}

.fa-the-red-yeti:before {
  content: "\F69D";
}

.fa-theater-masks:before {
  content: "\F630";
}

.fa-themeco:before {
  content: "\F5C6";
}

.fa-themeisle:before {
  content: "\F2B2";
}

.fa-thermometer:before {
  content: "\F491";
}

.fa-thermometer-empty:before {
  content: "\F2CB";
}

.fa-thermometer-full:before {
  content: "\F2C7";
}

.fa-thermometer-half:before {
  content: "\F2C9";
}

.fa-thermometer-quarter:before {
  content: "\F2CA";
}

.fa-thermometer-three-quarters:before {
  content: "\F2C8";
}

.fa-think-peaks:before {
  content: "\F731";
}

.fa-thumbs-down:before {
  content: "\F165";
}

.fa-thumbs-up:before {
  content: "\F164";
}

.fa-thumbtack:before {
  content: "\F08D";
}

.fa-ticket-alt:before {
  content: "\F3FF";
}

.fa-tiktok:before {
  content: "\E07B";
}

.fa-times:before {
  content: "\F00D";
}

.fa-times-circle:before {
  content: "\F057";
}

.fa-tint:before {
  content: "\F043";
}

.fa-tint-slash:before {
  content: "\F5C7";
}

.fa-tired:before {
  content: "\F5C8";
}

.fa-toggle-off:before {
  content: "\F204";
}

.fa-toggle-on:before {
  content: "\F205";
}

.fa-toilet:before {
  content: "\F7D8";
}

.fa-toilet-paper:before {
  content: "\F71E";
}

.fa-toilet-paper-slash:before {
  content: "\E072";
}

.fa-toolbox:before {
  content: "\F552";
}

.fa-tools:before {
  content: "\F7D9";
}

.fa-tooth:before {
  content: "\F5C9";
}

.fa-torah:before {
  content: "\F6A0";
}

.fa-torii-gate:before {
  content: "\F6A1";
}

.fa-tractor:before {
  content: "\F722";
}

.fa-trade-federation:before {
  content: "\F513";
}

.fa-trademark:before {
  content: "\F25C";
}

.fa-traffic-light:before {
  content: "\F637";
}

.fa-trailer:before {
  content: "\E041";
}

.fa-train:before {
  content: "\F238";
}

.fa-tram:before {
  content: "\F7DA";
}

.fa-transgender:before {
  content: "\F224";
}

.fa-transgender-alt:before {
  content: "\F225";
}

.fa-trash:before {
  content: "\F1F8";
}

.fa-trash-alt:before {
  content: "\F2ED";
}

.fa-trash-restore:before {
  content: "\F829";
}

.fa-trash-restore-alt:before {
  content: "\F82A";
}

.fa-tree:before {
  content: "\F1BB";
}

.fa-trello:before {
  content: "\F181";
}

.fa-tripadvisor:before {
  content: "\F262";
}

.fa-trophy:before {
  content: "\F091";
}

.fa-truck:before {
  content: "\F0D1";
}

.fa-truck-loading:before {
  content: "\F4DE";
}

.fa-truck-monster:before {
  content: "\F63B";
}

.fa-truck-moving:before {
  content: "\F4DF";
}

.fa-truck-pickup:before {
  content: "\F63C";
}

.fa-tshirt:before {
  content: "\F553";
}

.fa-tty:before {
  content: "\F1E4";
}

.fa-tumblr:before {
  content: "\F173";
}

.fa-tumblr-square:before {
  content: "\F174";
}

.fa-tv:before {
  content: "\F26C";
}

.fa-twitch:before {
  content: "\F1E8";
}

.fa-twitter:before {
  content: "\F099";
}

.fa-twitter-square:before {
  content: "\F081";
}

.fa-typo3:before {
  content: "\F42B";
}

.fa-uber:before {
  content: "\F402";
}

.fa-ubuntu:before {
  content: "\F7DF";
}

.fa-uikit:before {
  content: "\F403";
}

.fa-umbraco:before {
  content: "\F8E8";
}

.fa-umbrella:before {
  content: "\F0E9";
}

.fa-umbrella-beach:before {
  content: "\F5CA";
}

.fa-uncharted:before {
  content: "\E084";
}

.fa-underline:before {
  content: "\F0CD";
}

.fa-undo:before {
  content: "\F0E2";
}

.fa-undo-alt:before {
  content: "\F2EA";
}

.fa-uniregistry:before {
  content: "\F404";
}

.fa-unity:before {
  content: "\E049";
}

.fa-universal-access:before {
  content: "\F29A";
}

.fa-university:before {
  content: "\F19C";
}

.fa-unlink:before {
  content: "\F127";
}

.fa-unlock:before {
  content: "\F09C";
}

.fa-unlock-alt:before {
  content: "\F13E";
}

.fa-unsplash:before {
  content: "\E07C";
}

.fa-untappd:before {
  content: "\F405";
}

.fa-upload:before {
  content: "\F093";
}

.fa-ups:before {
  content: "\F7E0";
}

.fa-usb:before {
  content: "\F287";
}

.fa-user:before {
  content: "\F007";
}

.fa-user-alt:before {
  content: "\F406";
}

.fa-user-alt-slash:before {
  content: "\F4FA";
}

.fa-user-astronaut:before {
  content: "\F4FB";
}

.fa-user-check:before {
  content: "\F4FC";
}

.fa-user-circle:before {
  content: "\F2BD";
}

.fa-user-clock:before {
  content: "\F4FD";
}

.fa-user-cog:before {
  content: "\F4FE";
}

.fa-user-edit:before {
  content: "\F4FF";
}

.fa-user-friends:before {
  content: "\F500";
}

.fa-user-graduate:before {
  content: "\F501";
}

.fa-user-injured:before {
  content: "\F728";
}

.fa-user-lock:before {
  content: "\F502";
}

.fa-user-md:before {
  content: "\F0F0";
}

.fa-user-minus:before {
  content: "\F503";
}

.fa-user-ninja:before {
  content: "\F504";
}

.fa-user-nurse:before {
  content: "\F82F";
}

.fa-user-plus:before {
  content: "\F234";
}

.fa-user-secret:before {
  content: "\F21B";
}

.fa-user-shield:before {
  content: "\F505";
}

.fa-user-slash:before {
  content: "\F506";
}

.fa-user-tag:before {
  content: "\F507";
}

.fa-user-tie:before {
  content: "\F508";
}

.fa-user-times:before {
  content: "\F235";
}

.fa-users:before {
  content: "\F0C0";
}

.fa-users-cog:before {
  content: "\F509";
}

.fa-users-slash:before {
  content: "\E073";
}

.fa-usps:before {
  content: "\F7E1";
}

.fa-ussunnah:before {
  content: "\F407";
}

.fa-utensil-spoon:before {
  content: "\F2E5";
}

.fa-utensils:before {
  content: "\F2E7";
}

.fa-vaadin:before {
  content: "\F408";
}

.fa-vector-square:before {
  content: "\F5CB";
}

.fa-venus:before {
  content: "\F221";
}

.fa-venus-double:before {
  content: "\F226";
}

.fa-venus-mars:before {
  content: "\F228";
}

.fa-vest:before {
  content: "\E085";
}

.fa-vest-patches:before {
  content: "\E086";
}

.fa-viacoin:before {
  content: "\F237";
}

.fa-viadeo:before {
  content: "\F2A9";
}

.fa-viadeo-square:before {
  content: "\F2AA";
}

.fa-vial:before {
  content: "\F492";
}

.fa-vials:before {
  content: "\F493";
}

.fa-viber:before {
  content: "\F409";
}

.fa-video:before {
  content: "\F03D";
}

.fa-video-slash:before {
  content: "\F4E2";
}

.fa-vihara:before {
  content: "\F6A7";
}

.fa-vimeo:before {
  content: "\F40A";
}

.fa-vimeo-square:before {
  content: "\F194";
}

.fa-vimeo-v:before {
  content: "\F27D";
}

.fa-vine:before {
  content: "\F1CA";
}

.fa-virus:before {
  content: "\E074";
}

.fa-virus-slash:before {
  content: "\E075";
}

.fa-viruses:before {
  content: "\E076";
}

.fa-vk:before {
  content: "\F189";
}

.fa-vnv:before {
  content: "\F40B";
}

.fa-voicemail:before {
  content: "\F897";
}

.fa-volleyball-ball:before {
  content: "\F45F";
}

.fa-volume-down:before {
  content: "\F027";
}

.fa-volume-mute:before {
  content: "\F6A9";
}

.fa-volume-off:before {
  content: "\F026";
}

.fa-volume-up:before {
  content: "\F028";
}

.fa-vote-yea:before {
  content: "\F772";
}

.fa-vr-cardboard:before {
  content: "\F729";
}

.fa-vuejs:before {
  content: "\F41F";
}

.fa-walking:before {
  content: "\F554";
}

.fa-wallet:before {
  content: "\F555";
}

.fa-warehouse:before {
  content: "\F494";
}

.fa-watchman-monitoring:before {
  content: "\E087";
}

.fa-water:before {
  content: "\F773";
}

.fa-wave-square:before {
  content: "\F83E";
}

.fa-waze:before {
  content: "\F83F";
}

.fa-weebly:before {
  content: "\F5CC";
}

.fa-weibo:before {
  content: "\F18A";
}

.fa-weight:before {
  content: "\F496";
}

.fa-weight-hanging:before {
  content: "\F5CD";
}

.fa-weixin:before {
  content: "\F1D7";
}

.fa-whatsapp:before {
  content: "\F232";
}

.fa-whatsapp-square:before {
  content: "\F40C";
}

.fa-wheelchair:before {
  content: "\F193";
}

.fa-whmcs:before {
  content: "\F40D";
}

.fa-wifi:before {
  content: "\F1EB";
}

.fa-wikipedia-w:before {
  content: "\F266";
}

.fa-wind:before {
  content: "\F72E";
}

.fa-window-close:before {
  content: "\F410";
}

.fa-window-maximize:before {
  content: "\F2D0";
}

.fa-window-minimize:before {
  content: "\F2D1";
}

.fa-window-restore:before {
  content: "\F2D2";
}

.fa-windows:before {
  content: "\F17A";
}

.fa-wine-bottle:before {
  content: "\F72F";
}

.fa-wine-glass:before {
  content: "\F4E3";
}

.fa-wine-glass-alt:before {
  content: "\F5CE";
}

.fa-wix:before {
  content: "\F5CF";
}

.fa-wizards-of-the-coast:before {
  content: "\F730";
}

.fa-wodu:before {
  content: "\E088";
}

.fa-wolf-pack-battalion:before {
  content: "\F514";
}

.fa-won-sign:before {
  content: "\F159";
}

.fa-wordpress:before {
  content: "\F19A";
}

.fa-wordpress-simple:before {
  content: "\F411";
}

.fa-wpbeginner:before {
  content: "\F297";
}

.fa-wpexplorer:before {
  content: "\F2DE";
}

.fa-wpforms:before {
  content: "\F298";
}

.fa-wpressr:before {
  content: "\F3E4";
}

.fa-wrench:before {
  content: "\F0AD";
}

.fa-x-ray:before {
  content: "\F497";
}

.fa-xbox:before {
  content: "\F412";
}

.fa-xing:before {
  content: "\F168";
}

.fa-xing-square:before {
  content: "\F169";
}

.fa-y-combinator:before {
  content: "\F23B";
}

.fa-yahoo:before {
  content: "\F19E";
}

.fa-yammer:before {
  content: "\F840";
}

.fa-yandex:before {
  content: "\F413";
}

.fa-yandex-international:before {
  content: "\F414";
}

.fa-yarn:before {
  content: "\F7E3";
}

.fa-yelp:before {
  content: "\F1E9";
}

.fa-yen-sign:before {
  content: "\F157";
}

.fa-yin-yang:before {
  content: "\F6AD";
}

.fa-yoast:before {
  content: "\F2B1";
}

.fa-youtube:before {
  content: "\F167";
}

.fa-youtube-square:before {
  content: "\F431";
}

.fa-zhihu:before {
  content: "\F63F";
}

.sr-only {
  border: 0;
  clip: rect(0, 0, 0, 0);
  height: 1px;
  margin: -1px;
  overflow: hidden;
  padding: 0;
  position: absolute;
  width: 1px;
}

.sr-only-focusable:active,
.sr-only-focusable:focus {
  clip: auto;
  height: auto;
  margin: 0;
  overflow: visible;
  position: static;
  width: auto;
}

/*!
 * Font Awesome Free 5.15.1 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */

@font-face {
  font-family: "Font Awesome 5 Free";
  font-style: normal;
  font-weight: 400;
  font-display: block;
  src: url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-regular-400.eot?b01516c1808be557667befec76cd6318);
  src: url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-regular-400.eot?b01516c1808be557667befec76cd6318) format("embedded-opentype"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-regular-400.woff2?4a74738e7728e93c4394b8604081da62) format("woff2"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-regular-400.woff?3c6879c4f342203d099bdd66dce6d396) format("woff"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-regular-400.ttf?49f00693b0e5d45097832ef5ea1bc541) format("truetype"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-regular-400.svg?3602b7e8b2cb1462b0bef9738757ef8a) format("svg");
}

.far {
  font-family: "Font Awesome 5 Free";
  font-weight: 400;
}

/*!
 * Font Awesome Free 5.15.1 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */

@font-face {
  font-family: "Font Awesome 5 Free";
  font-style: normal;
  font-weight: 900;
  font-display: block;
  src: url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-solid-900.eot?8ac3167427b1d5d2967646bd8f7a0587);
  src: url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-solid-900.eot?8ac3167427b1d5d2967646bd8f7a0587) format("embedded-opentype"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-solid-900.woff2?8e1ed89b6ccb8ce41faf5cb672677105) format("woff2"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-solid-900.woff?4451e1d86df7491dd874f2c41eee1053) format("woff"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-solid-900.ttf?205f07b3883c484f27f40d21a92950d4) format("truetype"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-solid-900.svg?664de3932dd6291b4b8a8c0ddbcb4c61) format("svg");
}

.fa,
.fas {
  font-family: "Font Awesome 5 Free";
  font-weight: 900;
}

/*!
 * Font Awesome Free 5.15.1 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */

@font-face {
  font-family: "Font Awesome 5 Brands";
  font-style: normal;
  font-weight: 400;
  font-display: block;
  src: url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-brands-400.eot?e2ca6541bff3a3e9f4799ee327b28c58);
  src: url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-brands-400.eot?e2ca6541bff3a3e9f4799ee327b28c58) format("embedded-opentype"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-brands-400.woff2?f075c50f89795e4cdb4d45b51f1a6800) format("woff2"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-brands-400.woff?ad527cc5ec23d6da66e8a1d6772ea6d3) format("woff"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-brands-400.ttf?8300bd7f30e0a313c1d772b49d96cb8e) format("truetype"), url(/fonts/vendor/@fortawesome/fontawesome-free/webfa-brands-400.svg?2f12242375edd68e9013ecfb59c672e9) format("svg");
}

.fab {
  font-family: "Font Awesome 5 Brands";
  font-weight: 400;
}

