package race.car;

public class SectorTimer {
    private int[] sectorTimes;

    public int[] getSectorTimes() {
        return sectorTimes.clone();
    }

    public SectorTimer(int... a) {
        initSectorTimes(a);
    }

    public SectorTimer(boolean b, int... a) {
        System.arraycopy(a, 0, this.sectorTimes, 0, a.length);
    }

    public int getSectorTime(int i) {
        return sectorTimes[i];
    }

    public int[] getSectorTimesV2() {
        int[] res = new int[this.sectorTimes.length];
        System.arraycopy(this.sectorTimes, 0, res, 0, this.sectorTimes.length);
        return res;
    }

    public void initSectorTimes(int... arr) {
        this.sectorTimes = arr.clone();
    }

    public void setLapTimes(int... arr) {
        this.sectorTimes = arr;
    }

    public void setSectorTimesV2(int... arr) {
        initSectorTimes(arr);
    }

}
