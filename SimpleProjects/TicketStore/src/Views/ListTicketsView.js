import React from 'react';

export default function ListTicketsView(props) {
    let tableRows = props.tickets.map(ticket =>
        <tr key={ticket._id}>
            <td>{ticket.title}</td>
            <td>{ticket.event}</td>
            <td>{ticket.date}</td>
            <td>{ticket.mail}</td>
            <td>{ticket.Quantity}</td>
            {getTicketActions(ticket)}
        </tr>
    );

    function getTicketActions(ticket) {
        if(ticket._acl.creator === sessionStorage.getItem("userId"))
            return <td>
                <button onClick={props.onedit.bind(this, ticket._id)}>Edit</button>
                <div id="divider"></div>
                <button onClick={props.ondelete.bind(this, ticket._id)}>Delete</button>
            </td>
        else return <td>-</td>
    }

    return (
        <div className="tickets-view">
            <h1>Tickets</h1>
            <table className="tickets-table">
                <thead>
                <tr>
                    <th>Title</th>
                    <th>Event</th>
                    <th>Date</th>
                    <th>Contacts</th>
                    <th>Quantity</th>
                    <th>Actions</th>
                </tr>
                </thead>
                <tbody>
                {tableRows}
                </tbody>
            </table>
        </div>
    );
}