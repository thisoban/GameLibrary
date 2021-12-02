import logo from './logo.svg';
import './App.css';
import Home from './Pages/Home';
import Games from './Pages/GamesPage';
import { Route, BrowserRouter as Router, Switch } from 'react-router-dom';
import NavBar from './Components/NavBar';
// import GamesPage from './Pages/GamesPage';
// import GameCard from './Components/GameCard';
// import { StyledEngineProvider } from '@mui/material/styles';
function App() {
  return (
    <div className="App">
      <Router>
        <NavBar/>
        {/* <StyledEngineProvider injectFirst>
        <GameCard/>
        </StyledEngineProvider> */}
          <Switch>
            <Route path='/' exact component={Home} />
            <Route path='/Home' exact component={Home} />
            <Route path='/GamesPage' exact component={Games} />
          </Switch>
        
        </Router>

     
    </div>
  );
}

export default App;
