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
    
}

public int Partition(int[] arr, int start, int end){
    
}

public int BinarySearch(int[] arr, int n){
    
}