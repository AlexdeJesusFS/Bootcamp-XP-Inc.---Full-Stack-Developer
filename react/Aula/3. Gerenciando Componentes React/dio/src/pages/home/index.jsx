import { Link } from "react-router-dom";
import Button from "../../components/Button";

import React from 'react'

function Home() {
  return (
    <>
        <h1>Home</h1>
        <Button title="title">button 1</Button>
        <Button variant="secondary">button 2</Button>
        <Link to="/login">To Login</Link>
    </>
  )
}

export default Home