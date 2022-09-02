#include <iostream>
#include <fstream>
#include <vector>
using namespace std;

int main() {
	// Cau 5
    // File input.txt trong folder cmake-build-debug
    ifstream ifs("input.txt");
    if (!ifs.is_open())
        cout << "Error" ;
    int n, x, k = 0;
    ifs >> n;
    int arr[n][n], b[n * n];
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            ifs >> arr[i][j];
        }
    }
    cout << "Ma tran ke:" << endl;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            b[k++] = arr[i][j];
        }
    }
    cout << endl;
    cout << "Danh sach canh:" << endl;
    int z = 0;
    for (int i = 0; i < n; i++) {
        vector<int> v;
        for (int j = 0; j < n; j++) {
            x = b[z];
            z++;
            if (x == 1) {
                v.push_back(j);
            }
        }
        for (int j = 0; j < v.size(); j++) {
            cout << v[j] << " ";
        }
        cout << endl;
    }
    return 0;
}
