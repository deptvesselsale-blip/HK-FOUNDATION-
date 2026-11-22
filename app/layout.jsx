
import "./globals.css";

export const metadata = {
  title: "HK Foundation | Idris HK",
  description:
    "A platform for membership, community and civic participation."
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  );
}
