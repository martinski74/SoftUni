import React, { Component } from 'react';

export default class EditBookView extends Component {
    render() {
        return (
            <form className="edit-book-form" onSubmit={this.submitForm.bind(this)}>
                <h1>Edit Ticket</h1>
                <label>
                    <div>Title:</div>
                    <input type="text" required
                           defaultValue={this.props.title}
                           ref={e => this.titleField = e}/>
                </label>
                <label>
                    <div>Event:</div>
                    <input type="text" required
                           defaultValue={this.props.event}
                           ref={e => this.eventField = e}/>
                </label>
                <label>
                    <div>Date:</div>
                    <input type="date" required
                           defaultValue={this.props.date}
                           ref={e => this.dateField = e}/>
                </label>
                <label>
                    <div>Contacts:</div>
                    <input type="text" required
                           defaultValue={this.props.mail}
                           ref={e => this.contactsField = e}/>
                </label>
                <label>
                    <div>Quantity:</div>
                    <input type="numbers" required
                           defaultValue={this.props.Quantity}
                           ref={e => this.quantityField = e}/>
                </label>
                <div>
                    <p></p>
                </div>
                <div>
                    <input type="submit" value="Edit" />
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
