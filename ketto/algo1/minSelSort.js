arr = [5, 1, 2, 4, 63, 21]

const swap = (i, j) => {
    let z = arr[i]
    arr[i] = arr[j]
    arr[j] = z
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

let n = arr.length

for (let i = 0; i <= n - 2; i++) {
    let minInd = n - 1
    for (let j = n - 2; j >= i; j--) {
        if (arr[j] < arr[minInd]) {
            minInd = j
        }
//        else {
  //          minInd = n - 1
    //    }
    }
    swap(i, minInd)
}

console.log(arr)
