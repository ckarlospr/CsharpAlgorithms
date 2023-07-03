//Booble Sort
        public void BubbleSort(int[] arr)
        {
            Boolean sorted = false;
            int cnt = arr.Length - 1;

            while(!sorted){
                 sorted = true;
                 for(int i=0; i<cnt; i++){
                    if(arr[i]>arr[i+1]){
                        sorted=false;
                        Swap(arr, i, i+1);
                    }
                 }
                 cnt--;
            }
        }

        public void Swap(int[] arr, int pos1, int pos2)
        {

        }

        public void InsertionSort(int[] arr)
        {
            
        }

        public void QuickSort(int[] arr, int start, int end)
        {
            
        }

        public int Partition(int[] arr, int start, int end)
        {
            
        }

        public int BinarySearch(int[] arr, int n)
        {
            int start, end, mid, r = -1;
            start = 0;
            end = arr.Length;

            while(start<end){
                mid=(start+end)/2;
                if(arr[mid]==n){
                    r = mid;
                    break;
                }else if(arr[mid]>n){
                    start = mid;
                }else{
                    end = mid;
                }
            }
            return r;
        }