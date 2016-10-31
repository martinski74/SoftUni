function solve(description, sortingCriteria) {

    class Ticket {
        constructor(destination, price, status) {
            this.destinatoin = destination;
            this.price = price;
            this.status = status;
        }

        static sortTicket(tickets, criteria) {
            if (criteria === 'destination') {
                return tickets.sort((a, b) => a.destinatoin.localeCompare(b.destinatoin));
            } else if (criteria === 'price') {
                return tickets.sort((a, b) => a.price - b.price);
            } else {
                return tickets.status((a, b) => a.status.localeCompare(b.status));
            }
        }
    }

    return Ticket.sortTicket(
        description
            .map(description => {
                description = description.split(/\|/);
                return new Ticket(description[0], Number(description[1]), description[2]);
            }),
        sortingCriteria
    );

}

console.log(solve(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'destination')
);