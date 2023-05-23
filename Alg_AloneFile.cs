public void BubbleSort(int[] arr){
    int cnt = arr.Length;
    Boolean sorted = false;

    while(!sorted){
        sorted=true;
        for(int i=0; i<cnt-1; i++){
            if(arr[i] > arr[i+1]){
                Swap(arr, i, i+1)
                sorted=false;
            }
        }
        cnt--;
    }
    
}

public void Swap(int[] arr, int pos1, int pos2){
    int temp = arr[pos1];
    arr[pos1]=arr[pos2];
    arr[pos2]=temp;
}

public void InsertionSort(int[] arr){

    for(int i=1; i<arr.Length; i++){
        int j=i-1;
        int val = arr[i];

        while(j>=0 && arr[j]>val){
            arr[j+1]=arr[j];
            arr[j]=val;
            j--;
        }
    }
}

public void QuickSort(int[] arr, int start, int end){
    if(start >= end)return;
    int index = 0;

    index = Partition(arr, start, end);
    QuickSort(arr, start, index-1);
    QuickSort(arr, index+1, end);
}

public int Partition(int[] arr, int start, int end){
    int pivotValue = arr[end];
    int pivotIndex = start;

    for(int i=start; i<end; i++){
        if(arr[i]<pivotValue){
            Swap(arr, i, pivotIndex);
            pivotIndex++;
        }
    }
    Swap(arr, pivotIndex, end);
    return pivotIndex;
}

public int BinarySearch(int[] arr, int n){
    int start, end, mid, r=-1;
    start = 0;
    end = arr.Length;

    while(start>end){
        mid = (start+end)/2;

        if(arr[mid]==n){
            r=n;
            break;
        }else if(n > arr[mid]) {
            start=mid;
        }else{
            end = mid;
        }
    }
    return r;
}