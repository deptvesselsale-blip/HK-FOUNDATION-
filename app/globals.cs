
@import url('https://fonts.googleapis.com/css2?family=DM+Sans:wght@400;500;600;700&family=Manrope:wght@500;600;700;800&display=swap');

:root {
  --navy: #10233f;
  --blue: #1f5eff;
  --gold: #d7ad55;
  --ink: #172235;
  --muted: #667085;
  --paper: #f5f7fb;
}

* {
  box-sizing: border-box;
}

body {
  margin: 0;
  background: var(--paper);
  color: var(--ink);
  font-family: 'DM Sans', sans-serif;
}

a {
  text-decoration: none;
  color: inherit;
}

.shell {
  max-width: 1180px;
  margin: auto;
  padding: 0 24px;
}

.nav {
  height: 76px;
  background: white;
  display: flex;
  align-items: center;
  justify-content: space-between;
  border-bottom: 1px solid #e8edf4;
}

.brand {
  font: 800 19px Manrope;
  color: var(--navy);
}

.brand span {
  color: var(--gold);
}

.navlinks {
  display: flex;
  gap: 26px;
  color: #526075;
  font-size: 14px;
}

.btn {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  background: var(--blue);
  color: white;
  padding: 13px 20px;
  border-radius: 9px;
  font-weight: 700;
  font-size: 14px;
  border: 0;
  cursor: pointer;
}

.btn.light {
  background: white;
  color: var(--navy);
  border: 1px solid #dce3ed;
}

.hero {
  background: linear-gradient(115deg, #0d203a, #173a68 65%, #24508a);
  color: white;
  padding: 94px 0 88px;
}

.eyebrow {
  color: #e6c77f;
  font-weight: 700;
  text-transform: uppercase;
  letter-spacing: 2px;
  font-size: 11px;
}

.hero h1 {
  font: 800 clamp(38px, 6vw, 64px)/1.08 Manrope;
  max-width: 720px;
  margin: 18px 0;
}

.hero p {
  color: #d5deeb;
  max-width: 590px;
  font-size: 17px;
  line-height: 1.8;
}

.actions {
  display: flex;
  gap: 12px;
  margin-top: 30px;
  flex-wrap: wrap;
}

.section {
  padding: 68px 0;
}

.section h2 {
  font: 800 30px Manrope;
  color: var(--navy);
  margin: 0 0 12px;
}

.lead {
  color: var(--muted);
  line-height: 1.7;
  max-width: 650px;
}

.cards {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 18px;
  margin-top: 28px;
}

.card {
  background: white;
  border: 1px solid #e8edf4;
  border-radius: 14px;
  padding: 25px;
}

.card h3 {
  font: 700 18px Manrope;
  color: var(--navy);
}

.card p {
  font-size: 14px;
  color: var(--muted);
  line-height: 1.7;
}

.symbol {
  width: 42px;
  height: 42px;
  border-radius: 12px;
  background: #edf3ff;
  color: var(--blue);
  display: grid;
  place-items: center;
  font-size: 20px;
}

.band {
  background: #eaf0fa;
  padding: 42px 0;
}

.bandinner {
  display: flex;
  align-items: center;
  justify-content: space-between;
  gap: 20px;
}

.footer {
  background: #0d1d34;
  color: #c4cede;
  padding: 30px 0;
  font-size: 13px;
}

@media (max-width: 720px) {
  .navlinks {
    display: none;
  }

  .hero {
    padding: 70px 0;
  }

  .cards {
    grid-template-columns: 1fr;
  }

  .bandinner {
    align-items: flex-start;
    flex-direction: column;
  }
}
