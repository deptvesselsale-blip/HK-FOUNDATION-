
import Link from "next/link";

const items = [
  ["♧", "Membership", "Register as a member and receive your digital membership identity."],
  ["▦", "Member services", "Access your member profile, membership card and wallet."],
  ["✓", "Verified community", "A platform for verified members and responsible participation."]
];

export default function Home() {
  return (
    <>
      <header className="nav">
        <div className="shell" style={{display:"flex",alignItems:"center",justifyContent:"space-between",width:"100%"}}>
          <Link className="brand" href="/">HK <span>FOUNDATION</span></Link>
          <nav className="navlinks">
            <a href="#about">About</a>
            <a href="#membership">Membership</a>
            <a href="#community">Community</a>
          </nav>
          <Link className="btn" href="/membership">Become a member</Link>
        </div>
      </header>

      <main>
        <section className="hero">
          <div className="shell">
            <div className="eyebrow">Idris HK · HK Foundation</div>
            <h1>Stronger communities.<br/>A shared future.</h1>
            <p>A home for membership, connection and civic participation. Join a growing community and stay connected to the work that moves us forward.</p>
            <div className="actions">
              <Link className="btn" href="/membership">Register as a member</Link>
              <a className="btn light" href="#about">Explore the foundation</a>
            </div>
          </div>
        </section>

        <section className="section" id="about">
          <div className="shell">
            <div className="eyebrow">What we offer</div>
            <h2>One community, connected</h2>
            <p className="lead">HK Foundation brings member registration, identity verification and community updates together in one accessible platform.</p>
            <div className="cards">
              {items.map(([icon,title,desc]) => (
                <article className="card" key={title}>
                  <div className="symbol">{icon}</div>
                  <h3>{title}</h3>
                  <p>{desc}</p>
                </article>
              ))}
            </div>
          </div>
        </section>

        <section className="band" id="membership">
          <div className="shell bandinner">
            <div>
              <h2>Take your place in the community</h2>
              <p className="lead">Create your member profile and get started.</p>
            </div>
            <Link className="btn" href="/membership">Start registration</Link>
          </div>
        </section>
      </main>

      <footer className="footer">
        <div className="shell">© {new Date().getFullYear()} HK Foundation · Idris HK. All rights reserved.</div>
      </footer>
    </>
  );
}
