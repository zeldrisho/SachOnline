#include <iostream>
#include <fstream>
#include <vector>
#include <cstring>
using namespace std;

int n, m;
vector<int> adj[100];
bool visited[100];

void dfs(int u) {
    visited[u] = true;
    cout << u << " ";
    for (int x: adj[u]) {
        if (!visited[x]) {
            dfs(x);
        }
    }
}

void connectedComponent() {
    int ans = 0;
    memset(visited, false, sizeof(visited));
    for (int i = 1; i <= n; i++) {
        if (!visited[i]) {
            ++ans;
            cout << "Cac dinh thuoc thanh phan lien thong thu " << ans << ": ";
            dfs(i);
            cout << endl;
        }
    }
    if (ans == 1) {
        cout << "=> Do thi lien thong";
    } else {
        cout << "So thanh phan lien thong cua do thi: " << ans << endl;
        cout << "=> Do thi khong lien thong";
    }
}

int main() {
    ifstream ifs("do-thi-ko-lien-thong.txt");
//    ifstream ifs("do-thi-lien-thong.txt");
    ifs >> n >> m;
    int x, y;
    for (int i = 0; i < m; i++) {
        ifs >> x >> y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
    connectedComponent();
    ifs.close();
    return 0;
}
