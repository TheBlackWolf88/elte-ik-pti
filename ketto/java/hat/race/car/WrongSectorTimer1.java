package race.car;
public class SectorTimer {
    private int[] sectorTimes;

	public int[] getSectorTimes() {
		return sectorTimes.clone();
	}

    public SectorTimer(int[] a) {
        initSectorTimes(a);
    } 
    public SectorTimer(boolean b, int[] a) {
        System.arraycopy(a, this.sectorTimes);
    } 

    public int getSectorTime(int i){
        return sectorTimes[i];
    }
    public int[] getSectorTimesV2(){
        int[] res;
        System.arraycopy(this.sectorTimes, res);
        return res;
    }

    public void initSectorTimes(int[] arr){
        this.sectorTimes = arr.clone();
    }

    public void setLapTimes(int[] arr){
       this.sectorTimes = arr; 
    }

    public void setSectorTimesV2 (int[] arr){
        initSectorTimes(a);
    }
    
}
