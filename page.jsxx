
"use client";

import Link from "next/link";

export default function MembershipPage() {
  return (
    <main className="section">
      <div className="shell">
        <Link className="brand" href="/">HK <span>FOUNDATION</span></Link>

        <div style={{maxWidth:"650px",margin:"55px auto"}}>
          <div className="eyebrow">HK Foundation · Membership</div>
          <h1>Become a member</h1>
          <p className="lead">
            Join our community by completing the registration form below.
          </p>

          <form className="card" style={{display:"grid",gap:"18px"}}>
            <label>
              Full name
              <input required name="fullName" type="text" placeholder="Enter your full name" />
            </label>

            <label>
              Email address
              <input required name="email" type="email" placeholder="Enter your email" />
            </label>

            <label>
              Phone number
              <input required name="phone" type="tel" placeholder="Enter your phone number" />
            </label>

            <label>
              State
              <input required name="state" type="text" placeholder="Enter your state" />
            </label>

            <label>
              Local government area
              <input required name="lga" type="text" placeholder="Enter your LGA" />
            </label>

            <label>
              Create password
              <input required name="password" type="password" minLength={6} placeholder="Minimum 6 characters" />
            </label>

            <button className="btn" type="submit">
              Submit registration
            </button>

            <p style={{fontSize:"13px",color:"#777"}}>
              Registration and account creation will be connected to the secure
              membership system in a later step.
            </p>
          </form>
        </div>
      </div>
    </main>
  );
}
