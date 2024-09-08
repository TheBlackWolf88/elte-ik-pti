package uno.util;

import java.util.Objects;

public class Card {

    public final int value;
    public final Color color;
    public final CardType cardType;

    public Card(int value, Color color, CardType cardType) {
        this.value = value;
        this.color = color;
        this.cardType = cardType;
    }

    @Override
    public String toString() {
        return (cardType == CardType.VALUE) ? color + " " + value : color + " " + cardType;
    }

    @Override
    public int hashCode() {
        return Objects.hash(value, color, cardType);
    }

    @Override
    public boolean equals(Object that) {
        if (this == that) return true;
        else if (that instanceof Card) {
            Card thatActual = (Card) that;
            return this.cardType == thatActual.cardType &&
                    this.value == thatActual.value && this.color == thatActual.color;
        } else return false;
    }

    public boolean isPlayableOver(Card that) {
        if (this.cardType == CardType.VALUE) {
            return this.value == that.value || this.color == that.color;
        } else if (that.cardType == CardType.VALUE) {
            return this.color == that.color;
        }
        else return false;
    }
}
