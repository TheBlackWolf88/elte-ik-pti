package uno;

import uno.util.Card;

import java.util.ArrayList;
import java.util.List;

public class Player {
    private String name;
    private List<Card> hand;
    private Game game;

    public String getName() {
        return name;
    }

    public List<Card> getHand() {
        return new ArrayList<>(hand);
    }

    public Player(String name, List<Card> hand, Game game) {
        this.name = name;
        this.hand = hand;
        this.game = game;
    }

    public void addToHand(List<Card> cards) {
        hand.addAll(cards);
    }

    public void removeFromHand(int pos) {
        hand.remove(pos);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder("Player " + name + ": ");
        for (int i = 0; i < hand.size(); i++) {
            Card a = hand.get(i);
            sb.append(i + 1).append((a.isPlayableOver(game.currentCard)) ? "*" : "")
                    .append("=").append(a).append(" ");
        }
        return sb.toString();
    }
}
