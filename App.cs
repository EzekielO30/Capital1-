@import url("https://fonts.googleapis.com/css?family=Roboto+Slab:100,300,400,700");
@import url("https://fonts.googleapis.com/css?family=Raleway:300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i");
@import url("https://fonts.googleapis.com/css2?family=Manrope:wght@200..800&display=swap");

@import url("https://fonts.googleapis.com/css2?family=Manrope:wght@200..800&family=Roboto+Flex:opsz,wght@8..144,100..1000&family=Urbanist:ital,wght@0,100..900;1,100..900&display=swap");
.header {
  background-color: #1c1d1f;
  text-align: center;
  color: white;
  padding: 3%;
  font-size: 30px;
}

.card-body {
  margin-top: 5%;
  max-width: 80%;
}

img {
  width: 300px !important;
}

* {
  margin: 0;
  border: 0;
  box-sizing: border-box;
  font-family: 'Manrope',Manrope;
}

:root {
  --font-roboto: "Roboto Slab", serif;
  --font-raleway: "Raleway", sans-serif;
}

body {
  font-family: var(--font-roboto);
  background-color: #212426;
}

.app {
  padding: 4rem;

  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}

h1 {
  font-size: 3rem;
  letter-spacing: 0.9px;
  background: linear-gradient(
    90deg,
    rgba(249, 211, 180, 1) 0%,
    rgba(249, 211, 180, 0) 100%
  );
  background-clip: text;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  width: fit-content;
}

.search {
  width: 71%;
  margin: 4rem 0 2rem;

  display: flex;
  align-items: right;
  justify-content: right;

  padding: 1.5rem 1.75rem;
  border-radius: 3rem;
  background: #1f2123;
  -webkit-box-shadow: 5px 5px 7px #1c1d1f, -5px -5px 7px #222527;
  box-shadow: 5px 5px 7px #1c1d1f, -5px -5px 7px #222527;
}

.search input {
  flex: 1;
  border: none;
  font-size: 1.5rem;
  font-family: var(--font-raleway);
  font-weight: 500;
  padding-right: 1rem;

  outline: none;
  color: #a1a1a1;
  background: #1f2123;
}

.search img {
  width: 35px;
  height: 35px;
  cursor: pointer;
}

/* .search button {
  padding: 20px 40px;
  border-radius: 0.5rem;
  margin-left: 15px;
  color: #a1a1a1;
  font-family: var(--font-raleway);
  font-weight: 900;
  letter-spacing: 0.75px;
  font-size: 1.25rem;
  cursor: pointer;
  background: #1f2123;
  -webkit-box-shadow: 5px 5px 7px #1c1d1f, -5px -5px 7px #222527;
  box-shadow: 5px 5px 7px #1c1d1f, -5px -5px 7px #222527;
} */

.empty {
  width: 100%;
  margin-top: 3rem;

  display: flex;
  justify-content: center;
  align-items: center;
}

.empty h2 {
  font-size: 1.25rem;
  color: #f9d3b4;
  font-family: var(--font-raleway);
}

.container {
  width: 100%;
  margin-top: 3rem;

  display: flex;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
}

.movie {
  width: 310px;
  height: 460px;
  margin: 1.5rem;

  position: relative;
  border-radius: 12px;
  overflow: hidden;
  border: none;

  transition: all 0.4s cubic-bezier(0.175, 0.885, 0, 1);
  box-shadow: 0px 13px 10px -7px rgba(0, 0, 0, 0.1);
}

.movie div:nth-of-type(1) {
  position: absolute;
  padding: 16px;
  width: 100%;
  opacity: 0;
  top: 0;
  color: #f9d3b4;
}

.movie:hover {
  box-shadow: 0px 30px 18px -8px rgba(0, 0, 0, 0.1);
  transform: scale(1.05, 1.05);
}

.movie div:nth-of-type(2) {
  width: 100%;
  height: 100%;
}

.movie div:nth-of-type(2) img {
  height: 100%;
  width: 100%;
}

.movie div:nth-of-type(3) {
  z-index: 2;
  background-color: #343739;
  padding: 16px 24px 24px 24px;

  position: absolute;
  bottom: 0;
  right: 0;
  left: 0;
}

.movie div:nth-of-type(3) span {
  font-family: "Raleway", sans-serif;
  text-transform: uppercase;
  font-size: 13px;
  letter-spacing: 2px;
  font-weight: 500;
  color: #f0f0f0;
}

.movie div:nth-of-type(3) h3 {
  margin-top: 5px;
  font-family: "Roboto Slab", serif;
  color: #f9d3b4;
}

.movie:hover div:nth-of-type(2) {
  height: 100%;
  opacity: 0.3;
}

.movie:hover div:nth-of-type(3) {
  background-color: transparent;
}

.movie:hover div:nth-of-type(1) {
  opacity: 1;
}

@media screen and (max-width: 600px) {
  .app {
    padding: 4rem 2rem;
  }

  .search {
    padding: 1rem 1.75rem;
    width: 100%;
  }

  .search input {
    font-size: 1rem;
  }

  .search img {
    width: 20px;
    height: 20px;
  }
}

@media screen and (max-width: 400px) {
  .app {
    padding: 4rem 1rem;
  }

  h1 {
    font-size: 2rem;
  }

  .container {
    margin-top: 2rem;
  }

  .movie {
    width: "100%";
    margin: 1rem;
  }
}
