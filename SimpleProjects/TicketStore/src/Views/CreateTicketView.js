import React, {Component} from 'react';

export default class CreateTicketView extends Component {
    render() {
        return (
            <form className="create-ticket-form" onSubmit={this.submitForm.bind(this)}>
                <h1>Add Ticket</h1>
                <label>
                    <div>Title:</div>
                    <input type="text" required
                           ref={e => this.titleField = e}/>
                </label>
                <label>
                    <div>Event:</div>
                    <input type="text" required
                           ref={e => this.eventField = e}/>
                </label>
                <label>
                    <div>Date:</div>
                    <input type="date" required
                           ref={e => this.dateField = e}/>
                </label>
                <label>
                    <div>Contacts:</div>
                    <input type="text" required
                           ref={e => this.contactsField = e}/>
                </label>
                <label>
                    <div>Quantity:</div>
                    <input type="numbers" required
                           ref={e => this.quantityField = e}/>
                </label>
                <div>
                    <p></p>
                </div>
                <div>
                    <input type="submit" value="Add your ticket"/>
                </div>
            </form>
        );
    }

    submitForm(event) {
        event.preventDefault();
        this.props.onsubmit(
            this.titleField.value,
            this.eventField.value,
            this.dateField.value,
            this.contactsField.value,
            this.quantityField.value,
        );
    }
}