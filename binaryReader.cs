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


public int BinarySearch(int[] arr, int n){
    int start, end, mid, r=-1;
    start = 0;
    end = arr.Length;

    while(start<end){
        mid = (start+end)/2;
        if(arr[mid]==m){
            r=mid;
            break;
        }else if(arr[mid]>n){
            start=mid;
        }else{
            end=mid;
        }
    }
    return r;
}