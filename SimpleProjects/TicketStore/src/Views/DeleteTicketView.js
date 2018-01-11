import React, { Component } from 'react';

export default class DeleteTicketView extends Component {
    render() {
        return (
            <form className="delete-ticket-form" onSubmit={this.submitForm.bind(this)}>
                <h1>Confirm Delete Ticket</h1>
                <label>
                    <div>Title:</div>
                    <input type="text" disabled="true"
                           defaultValue={this.props.title}
                           ref={e => this.titleField = e}/>
                </label>
                <label>
                    <div>Event:</div>
                    <input type="text" disabled="true"
                           defaultValue={this.props.event}
                           ref={e => this.eventField = e}/>
                </label>
                <label>
                    <div>Date:</div>
                    <input type="date" disabled="true"
                           defaultValue={this.props.date}
                           ref={e => this.dateField = e}/>
                </label>
                <label>
                    <div>Contacts:</div>
                    <input type="text" disabled="true"
                           defaultValue={this.props.mail}
                           ref={e => this.contactsField = e}/>
                </label>
                <label>
                    <div>Quantity:</div>
                    <input type="numbers" disabled="true"
                           defaultValue={this.props.Quantity}
                           ref={e => this.quantityField = e}/>
                </label>
                <div>
                    <p></p>
                </div>
                <div>
                    <input type="submit" value="Delete" />
                </div>
            </form>
        );
    }

    submitForm(event) {
        event.preventDefault();
        this.props.onsubmit(
            this.props.ticketId,
            this.titleField.value,
            this.eventField.value,
            this.dateField.value,
            this.contactsField.value,
            this.quantityField.value,
        );
    }
}
