#include <iostream>
#include <fstream>
using namespace std;

int arr[1001][1001], n;

string isValid(int arr[][1001], int n) {
    for (int i = 0; i < n; i++) {
        if (arr[i][i] != 0) {
            return "Do thi tren khong hop le";
        }
    }
    return "Do thi tren hop le";
}

string isSymmetric(int arr[][1001], int n)
{
    for (int i = 0; i < n-1; i++)
        for (int j = i+1; j < n; j++)
            if (arr[i][j] != arr[j][i])
                return "Do thi tren khong doi xung";
    return "Do thi tren doi xung";
}

int main() {
	// Cau 1, 2, 3, 4
    // File input.txt trong folder cmake-build-debug
    ifstream ifs("input.txt");
    if (!ifs.is_open())
        cout << "Error" ;
    ifs >> n;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            ifs >> arr[i][j];
        }
    }
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
    cout << endl;
    cout << isValid(arr, n) << endl;
    cout << isSymmetric(arr, n) << endl;
    cout << endl;
    int deg;
    for(int i = 0; i < n; i++) {
        deg = 0;
        for(int j = 0; j < n; j++) {
            if(arr[i][j] != 0) deg++;
        }
        cout << "Bac cua dinh " << i + 1 << " la: " << deg << endl;
    }
    return 0;
}
