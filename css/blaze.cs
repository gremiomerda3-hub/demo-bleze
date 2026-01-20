* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Segoe UI', sans-serif;
}

body {
  background: #0b0b0b;
  color: #fff;
  display: flex;
}

.sidebar {
  width: 220px;
  background: #050505;
  height: 100vh;
  padding: 20px;
  box-shadow: 0 0 20px #00ff8840;
}

.logo {
  font-size: 22px;
  font-weight: bold;
  color: #00ff88;
  margin-bottom: 30px;
}

nav a {
  display: block;
  padding: 12px;
  margin-bottom: 10px;
  border-radius: 6px;
  cursor: pointer;
  color: #ccc;
  transition: 0.3s;
}

nav a:hover,
nav a.active {
  background: #00ff88;
  color: #000;
  box-shadow: 0 0 10px #00ff88;
}

.main {
  flex: 1;
}

header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 15px 30px;
  background: #0f0f0f;
  box-shadow: 0 2px 10px #000;
}

.saldo span {
  color: #00ff88;
  font-weight: bold;
}

.depositar {
  background: linear-gradient(45deg, #00ff88, #00cc66);
  border: none;
  padding: 12px 25px;
  font-weight: bold;
  cursor: pointer;
  border-radius: 6px;
  box-shadow: 0 0 15px #00ff88;
}

.banner {
  margin: 30px;
  padding: 40px;
  background: linear-gradient(135deg, #111, #1a1a1a);
  border-radius: 12px;
  box-shadow: 0 0 20px #00ff8830;
}

.banner h1 {
  color: #00ff88;
  margin-bottom: 10px;
}

.games {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(180px, 1fr));
  gap: 20px;
  padding: 0 30px;
}

.game-card {
  background: #111;
  height: 120px;
  border-radius: 10px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 20px;
  cursor: pointer;
  transition: 0.3s;
  box-shadow: 0 0 10px #000;
}

.game-card:hover {
  transform: translateY(-5px);
  box-shadow: 0 0 20px #00ff88;
}
