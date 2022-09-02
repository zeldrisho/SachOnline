#include <iostream>
#include <fstream>
using namespace std;

int main() {
    // Cau 5
    // File input.txt trong folder cmake-build-debug
    ifstream ifs("input.txt");
    int arr[100][100], n, cnt = 0, b[100], c[100], k = 0;
    ifs >> n;
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
            ifs >> arr[i][j];
        }
    }
    cout << n << " ";
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
            if (arr[i][j] == 1) {
                if (j > i) {
                    cnt++;
                    b[cnt] = i;
                    c[cnt] = j;
                }
                k = 1;
            }
        }
    }
    cout << cnt << endl;
    for (int i = 1; i <= cnt; i++)
        cout << b[i] << " " << c[i] << endl;
    return 0;
}