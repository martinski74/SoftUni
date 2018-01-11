import React from 'react';

export default function HomeView(props) {
    return <div className="home-view">
        <h1>Home</h1>
        <h2>Welcome to our online market</h2>
        {
            props.username ?
                <p>Welcome, {props.username}</p>
                :
                    <p>No user logged in</p>
        }
    </div>
}
