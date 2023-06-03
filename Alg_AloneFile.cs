public void BubbleSort(int[] arr){
    int cnt = 0;
    Boolean sorted = false;

    while(!sorted){
        sorted = true;
        for(int i=0; i<cnt-1; i++){
            if(arr[i] > arr[i+1]){
                Swap(arr, i, i+1);
                sorted = flase;
            }
        }
        cnt++;
    }
    
}

public void Swap(int[] arr, int pos1, int pos2){
    int temp = arr[pos1];
    arr[pos1] = arr[pos2];
    arr[pos2] = temp;
}

public void InsertionSort(int[] arr){
    for(int i=1; i<arr.Length; i++){
        int j=i-1;
        int temp = arr[i];
        while(j>=0 && arr[j]>temp){
            arr[j+1] = arr[j];
            arr[j] = temp;
            j--;
        }
    }
}

public void QuickSort(int[] arr, int start, int end){
    if(start >= end) return;
    int index = Partition(arr, start, end);
    QuickSort(arr, start, index-1);
    QuickSort(arr, index+1, end);
}

public int Partition(int[] arr, int start, int end){
    pivotIndex = (start + end ) /2;
    pivotValue = arr[end];

    for(int i=start; i<end; i++){
        if(arr[i]<pivotValue){
            Swap(arr, pivotIndex, i);
            pivotIndex++;
        }
    }
    Swap(arr, pivotIndex, end);
    return pivotIndex;
}

public int BinarySearch(int[] arr, int n){
    int start, end, mid, r=-1;
    start=0;
    end=arr.Length;
    while(start<end){
        mid=(start+end)/2;
        if(arr[mid]==n){
            r=mid;
            break;
        }else if(arr[mid]>n){
            start = mid;
        }else if(arr[mid]>n){
            end = mid;
        }
    }
    return r;
}

// Binary reader
OpenFileDialog ofd = new OpenFileDialog();
string path="";
if(ofd.ShowDialog == ResultDialog.OK){
    path=ofd.FileName;
    FileStream fs = new FileStream(path, FileMode.Open);
    BinaryReader br = new BinaryReader(fs);

    Byte[] bites = br.ReadBytes(10);
    Array.Reverse(bites);
    foreach(Byte b in bites) Console.Write(b);
    
}