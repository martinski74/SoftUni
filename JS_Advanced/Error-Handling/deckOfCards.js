function printDeckOfCards(cards) {
    class Card {
        constructor(face, suit) {
            this.face = face;
            this.suit = suit;
        }

        get face() {
            return this._face;
        }

        set face(face) {
            const validFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
            if (!validFaces.includes(face))
                throw new Error("Invalid card face: " + face);
            this._face = face;
        }

        get siut() {
            return this._suit;
        }

        set suit(suit) {
            const validSuits = ['S', 'H', 'D', 'C'];
            if (!validSuits.includes(suit))
                throw new Error("Invalid card suit: " + suit);
            this._suit = suit;
        }

        toString() {
            let suitToChar = {
                'S': "\u2660", // ♠
                'H': "\u2665", // ♥
                'D': "\u2666", // ♦
                'C': "\u2663", // ♣
            };
            return this.face + suitToChar[this._suit];
        }
    }
    let deck = [];
    for (let cardStr of cards) {
        let face = cardStr.substring(0, cardStr.length-1);
        let suit = cardStr.substr(cardStr.length-1, 1);
        try {
            deck.push(new Card(face, suit));
        }
        catch (err) {
            console.log("Invalid card: " + cardStr);
            return;
        }
    }
    console.log(deck.join(' '));
}

