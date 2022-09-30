#include <iostream>
#include <cstring>
#include <fstream>
using namespace std;

const int maxn = 101;

typedef int arr[maxn];
typedef int arr2[maxn][maxn];

ifstream ifs("input.txt");
ofstream ofs("output.txt");

// Nhập dữ liệu.
void enter(int &n, int &m, arr2 adj, arr deg)
{
    ifs >> n >> m;
    memset(adj, 0, sizeof(adj));
    memset(deg, 0, sizeof(deg));

    for (int i = 1; i <= m; ++i)
    {
        int u, v;
        ifs >> u >> v;

        ++adj[u][v];
        ++adj[v][u];

        ++deg[u];
        ++deg[v];
    }
}

// Kiểm tra điều kiện đồ thị Hamilton.
bool check_hamilton_graph(int n, arr deg)
{
    for (int u = 1; u <= n; ++u)
        if (deg[u] < 2)
            return false;

    return true;
}

// In một chu trình Hamilton.
void print_hamilton_circuit(int n, arr circuit)
{
    for (int i = 1; i <= n; ++i)
        ofs << circuit[i] << ' ';
    ofs << circuit[1] << endl;
}

// Quay lui tìm các chu trình Hamilton.
void find_hamilton_circuit(int i, int n, arr2 adj, arr circuit, arr is_free)
{
    // Thử chọn các đỉnh v kề với đỉnh liền trước trong chu trình và chưa thăm.
    for (int v = 1; v <= n; ++v)
        if (is_free[v] && adj[circuit[i - 1]][v])
        {
            // Ghi nhận đỉnh v vào chu trình.
            circuit[i] = v;

            // Nếu chưa chọn đủ n đỉnh thì tiếp tục chọn.
            if (i < n)
            {
                // Đánh dấu đỉnh v đã chọn.
                is_free[v] = false;

                // Gọi đệ quy thử chọn đỉnh tiếp theo.
                find_hamilton_circuit(i + 1, n, adj, circuit, is_free);

                // Loại bỏ đỉnh v khỏi chu trình để thử trường hợp khác.
                is_free[v] = true;
            }
                // Đã chọn đủ n đỉnh và đỉnh thứ n tới được đỉnh 1
                // Kết luận đã tìm được chu trình Hamilton.
            else if (adj[v][circuit[1]])
                print_hamilton_circuit(n, circuit);
        }
}

// Xử lý các trường hợp.
void solution(int n, arr2 adj, arr deg, arr is_free, arr circuit)
{
    fill(is_free + 1, is_free + n + 1, 1);
    circuit[1] = 1;

    if (!check_hamilton_graph(n, deg))
        ofs << 0;
    else
        find_hamilton_circuit(2, n, adj, circuit, is_free);
}

int main()
{
    int n, m;
    arr2 adj;
    arr deg, is_free, circuit;

    enter(n, m, adj, deg);
    solution(n, adj, deg, is_free, circuit);

    ifs.close();
    ofs.close();

    return 0;
}
