import { Header } from "../../components/Header";
import ListItem from "../../components/ListItem";
import background from '../../assets/background.png';
import './style.css';
import { useState, UseState } from 'react';

function App() {
  const [user, setUser] = useState('');
  const [currentUser, currentSetUser] = useState(null);
  const [repos, setRepos] = useState(null);

  const handleGetData = async () => {
    const userData = await fetch(`https://api.github.com/users/${user}`);
    const newUser = await userData.json();
  };

  return (
    <div className="App">
      <Header />
      <div className="content">
        <img src={background} className="background" alt="background app" />
        <div className="info">
          <div>
            <input name="user" value={user} onChange={event => setUser(event.target.value)} placeholder="@username" />
            <button onClick={handleGetData}>Find</button>
          </div>
    
          <div className="perfil">
            <img src="https://avatars.githubusercontent.com/u/65736748?v=4" className="profile" alt="profile"/>
            <div>
              <h3>Alex de Jesus</h3>
              <span>@AlexdeJesusFS</span>
              <p>description github here</p>
            </div>
          </div>
          
          <hr/>

          <div>
            <h1 className="repositories">Repositories</h1>
            <ListItem title="Title" description="description"/>
          </div>

        </div>
      </div>
    </div>
  );
}

export default App;
