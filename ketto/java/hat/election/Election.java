package election;

import election.candidate.Candidate;

public class Election {
    private int[] voteCounts;

    public Election() {
        int len = Candidate.values().length
        voteCounts = new int[len];
    }

    public void addVote(Candidate c) {
       voteCounts[c.ordinal()]; 
    }

    public void addVotes(Candidate c, int n) {
       for (int i = 0; i < n; i++) {
           addVote(c);
        
       } 
    }

    public int getCandidateCountWithMoreVotesThan(int a){
        int n = 0;
        for (int elem : voteCounts) {
            if (elem > a) n++; 
        }
        return n;
    }

    public Candidate[] getCandidatesWithMoreVotesThan(int a){
        Candidate[] arr = new Candidate[getCandidateCountWithMoreVotesThan(a)];
        return a;
        //rakert van rendesen ptsdm a javatol?
    }

    public Candidate getWinner(){
        return Candidate.JACK;
    }

    private int getWinningIdx() {
        return 0;
    }
    
    
}
