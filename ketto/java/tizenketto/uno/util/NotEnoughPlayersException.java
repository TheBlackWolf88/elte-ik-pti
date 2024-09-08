package uno.util;

public class NotEnoughPlayersException extends Exception {
    public NotEnoughPlayersException(int pCount) {
        super("Only " + pCount + "players were given");
    }
}
