let arr = [15, 19, 6, 8, 11]
let cSwap = 0
let cIter = 0
let cComp = 0

const defa = () => {

    arr = [15, 19, 6, 8, 11]
    cSwap = 0;
    cIter = 0;
    cComp = 0;
}

const swap = (i, j) => {
    let z = arr[i]
    arr[i] = arr[j]
    arr[j] = z
    cSwap++
}

const insertion_sort = () => {
    for (let i = 1; i < arr.length; i++) {
        cIter++
        let j = i;
        while (j > 0 && arr[j - 1] > arr[j]) {
            cIter++;
            cComp++;
            swap(j - 1, j)
            j--
        }
    }

}

const search_max = (k) => {
    let max = 0
    for (let i = 1; i <= k; i++) {
        cIter++
        cComp++;
        if (arr[i] > arr[max]) max = i;
    }
    return max;
}

const max_sel_sort = () => {
    for (let k = arr.length - 1; k >= 1; k--) {
        cIter++
        let maxi = search_max(k)
        swap(maxi, k)
        console.log(arr)
    }

}

insertion_sort()
console.log(arr)
console.log("cIter=" + cIter)
console.log("cSwap=" + cSwap)
console.log("cComp=" + cComp)


defa()

arr = [12, 6, 9, 8, 10, 1]
max_sel_sort()
console.log(arr)
console.log("cIter=" + cIter)
console.log("cSwap=" + cSwap)
console.log("cComp=" + cComp)
