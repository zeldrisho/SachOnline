#include <iostream>
#include <fstream>
using namespace std;

void dsCanhThanhMaTranKe() {
    ifstream ifs("ds-canh.txt");
//    n dinh, m canh
    int n, m;
    int arr[100][100];
    ifs >> n >> m;
    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        arr[x][y] = arr[y][x] = 1;
    }
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
            cout << arr[i][j] << " ";
        }
        cout << endl;
    }
    ifs.close();
}
