import { Header } from "../../components/Header";
import ListItem from "../../components/ListItem";
import Button from "../../components/Button";
import Input from "../../components/Input";
import NotFound from "../../components/NotFound"

import background from '../../assets/background.png';
import './style.css';
import { useState } from 'react';

function App() {
  const [user, setUser] = useState('');
  const [currentUser, setCurrentUser] = useState(null);
  const [repos, setRepos] = useState(null);
  const [error, setError] = useState(false);

  const handleGetData = async () => {
    setError(false);
    setCurrentUser(null);
    setRepos(null);

    const userData = await fetch(`https://api.github.com/users/${user}`);
    if (userData.status === 404) {
      setError(true);
      return;
    }
    const newUser = await userData.json();

    if (newUser.name) {
      const {avatar_url, name, login, bio} = newUser;
      setCurrentUser({avatar_url, name, login, bio});

      const reposData = await fetch(`https://api.github.com/users/${user}/repos`);
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
            <Input name="user" value={user} onChange={event => setUser(event.target.value)} placeholder="@username" />
            <Button onClick={handleGetData}>Find</Button>
          </div>

          {error ? (
            <NotFound message="User Not Found. Please try again with other name."/>
          ) : null}

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
          ) : !error && !currentUser ? (
            <>
            <br/>
            <br/>
              <h2>Search for a github username above to see more information and their repositories</h2>
            </>
          ) : null }

          {repos?.length ? (
            <div>
              <h1 className="repositories">Repositories</h1>
              {repos.map((repo) => (
                <ListItem key={repo.id} title={repo.name} description={repo.description} />
              ))}
            </div>
          ) : null}

        </div>
      </div>
    </div>
  );
};

export default App;