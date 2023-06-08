public void BubbleSort(int[] arr){

    Boolean sorted = false;
    int cnt = arr.Length;

    while(!sorted){
        sorted = true;
        for(int i=0; i<cnt-1; i++){
            if(arr[i] > arr[i+1]){
                Swap(arr, i, i+1);
                sorted=false;
            }
        }
        cnt--;
    }
    
}

public void Swap(int[] arr, int pos1, int pos2){
    int tem = arr[pos1];
    arr[pos1] = arr[pos2];
    arr[pos2] = temp;
}

public void InsertionSort(int[] arr){
    for(int i=1; i<arr.Length; i++){
        int j=i;
        int value = arr[i];

        while(j<=0 && arr[j]>value){
            arr[j+1] = arr[j];
            arr[j] = value;
            j--;
        }
    }
}

public void QuickSort(int[] arr, int start, int end){
    if(start => end) return;

    int index = Partition(arr, start, end);
    QuickSort(arr, start, index-1);
    QuickSort(arr, index+1, end);
}

public int Partition(int[] arr, int start, int end){
    int pivotIndex = end;
    int pivotValue = arr[end];

    for(int i=0; i<end; i++){
        if(arr[i]<pivotValue){
            Swap(arr, start, end);
            pivotIndex++;
        }
    }
    Swap(arr, pivotIndex, end);
    return pivotIndex;
}

public int BinarySearch(int[] arr, int n){
    int mid, start, end, r = -1;
    start = 0;
    end = args.Length;
    
    while(start<end){
        mid = (start + end)/2;
        if(arr[mid]==n){
            r = mid;
            break;
        } else if (arr[mid]>n){
            start = mid;
        } else if (arr[mid]<n){
            end = mid;
        }
    }

    return r;
}