#include <iostream>
#include <fstream>
using namespace std;

int main() {
    ifstream ifs("input.txt");
    int arr[100][100], n, cnt = 0, b[100], c[100], k = 0;
    ifs >> n;
    cout << "Tap dinh cua do thi: ";
    for (int i = 1; i <= n; i++) {
        cout << i << " ";
    }
    cout << endl;
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
            ifs >> arr[i][j];
        }
    }
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
    cout << "Tap canh cua do thi:" << endl;
    for (int i = 1; i <= cnt; i++)
        cout << b[i] << " " << c[i] << endl;
    ifs.close();
    return 0;
}