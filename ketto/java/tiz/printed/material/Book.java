package printed.material;

public class Book {
    public static final String defaultAuthor = "John Steinbeck";
    public static final String defaultTitle= "Of Mice and Men";
    public static final int defaultPageCount= 107;

    private String author;
    private String title;
    private int pageCount;

    public String getAuthor() {
        return author;
    }

    public String getTitle() {
        return title;
    }

    public int getPageCount() {
        return pageCount;
    }

    public Book() {
        this.author = defaultAuthor;
        this.title = defaultTitle;
        this.pageCount = defaultPageCount;
    }

    public Book(String author, String title, int pageCount) {
        this.author = author;
        this.title = title;
        this.pageCount = pageCount;
    }

    private void checkInitData(String author, String title, int pageCount) {}
}
