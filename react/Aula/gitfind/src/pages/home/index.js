import { Header } from "../../components/Header";
import background from '../../assets/background.png';
import './style.css';

function App() {
  return (
    <div className="App">
      <Header />
      <div className="content">
        <img src={background} className="background" alt="background app" />
        <div className="info">
          <div>
            <input name="user" placeholder="@username" />
            <button>Find</button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default App;
