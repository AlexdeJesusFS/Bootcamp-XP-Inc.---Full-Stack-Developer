import { Header } from "../../components/Header";
import ListItem from "../../components/ListItem";
import background from '../../assets/background.png';
import './style.css';
import { useState } from 'react';

function App() {
  const [user, setUser] = useState('');
  const [currentUser, setCurrentUser] = useState(null);
  const [repos, setRepos] = useState(null);

  const handleGetData = async () => {
    const userData = await fetch(`https://api.github.com/users/${user}`);
    const newUser = await userData.json();

    if (newUser.name) {
      const {avatar_url, name, login, bio} = newUser;
      setCurrentUser({avatar_url, name, login, bio});

      const reposData = await fetch(`https://api.github.com/users/${newUser.name}/repos`);
      const newRepos = await reposData.json();

      if (newRepos.length) {
        setRepos(newRepos);
      }
    }
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

          {currentUser?.name ? (
            <>
              <div className="perfil">
                <img src={currentUser.avatar_url} className="profile" alt="profile"/>
                <div>
                  <h3>{currentUser.name}</h3>
                  <span>@{currentUser.login}</span>
                  <p>{currentUser.bio}</p>
                </div>
              </div>
              <hr />
            </>
          ) : null};

          {repos?.lenght ? (
            <div>
              <h1 className="repositories">Repositories</h1>
              {repos.map((repo) => (
                <ListItem title={repo.name} description={repo.description} />
              ))}
            </div>
          ) : null};

        </div>
      </div>
    </div>
  );
};

export default App;
