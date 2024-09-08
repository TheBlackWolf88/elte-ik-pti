package worker.schedule;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
import java.util.Map.Entry;

public class WorkerSchedule {
    private HashMap<Integer, HashSet<String>> weekToWorkers;

    public WorkerSchedule() {
        weekToWorkers = new HashMap<>();
    }

    public void add (int week, HashSet<String> names) {
        if (weekToWorkers.containsKey(week)) {
           weekToWorkers.get(week).addAll(names);
        } else {
            weekToWorkers.put(week, names);
        }
    }

    public void add (HashSet<Integer> weeks, ArrayList<String> names) {
        HashSet<String> n = new HashSet<>(names);
        for(Integer w : weeks) {
            this.add(w, n);
        }

    }

    public boolean isWorkingOnWeek (String name, int week) {
        return weekToWorkers.get(week).contains(name);
    }

    public HashSet<Integer> getWorkWeeks (String name) {
        HashSet<Integer> res = new HashSet<>();
        for (Entry<Integer, HashSet<String>> entry : weekToWorkers.entrySet()){
            if (entry.getValue().contains(name)) res.add(entry.getKey());
        }
        return res;
    }
}
