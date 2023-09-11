#include <iostream>
#include <algorithm>
#include <vector>
#include <queue>
#include <cstring>
using namespace std;

int n, m, map[21][21], visited[21][21], mx;
int dy[4] = { -1, 0, 1, 0 };
int dx[4] = { 0, 1, 0, -1};
vector<pair<int, int>> black;

int check() {
	int ret = 0;
	for (auto a : black) {
		if (!visited[a.first][a.second]) {
			int cnt = 1, flag = 0;
			visited[a.first][a.second] = 1;
			queue<pair<int, int>> q;
			q.push({ a.first, a.second });
			while (q.size()) {
				int y = q.front().first;
				int x = q.front().second;
				q.pop();
				for (int i = 0; i < 4; i++) {
					int ny = y + dy[i];
					int nx = x + dx[i];
					if (ny >= 0 && ny < n && nx >= 0 && nx < m && !visited[ny][nx]) {
						if (!map[ny][nx]) {
							flag = 1;
						}
						else if (map[ny][nx] == 2) {
							cnt++;
							visited[ny][nx] = 1;
							q.push({ ny, nx });
						}
					}
				}
			}
			if (flag) cnt = 0;
			ret += cnt;
		}
	}
	return ret;
}

int main() {
	cin >> n >> m;
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			cin >> map[i][j];
			if (map[i][j] == 2) black.push_back({ i, j });
		}
	}

	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			for (int y = i; y < n; y++) {
				for (int x = 0; x < m; x++) {
					if (y == i && x == 0) x = j + 1;
					if (x == m) break;
					if (!map[i][j] && !map[y][x]) {
						map[i][j] = 1;
						map[y][x] = 1;
						mx = max(mx, check());
						map[i][j] = 0;
						map[y][x] = 0;
						memset(visited, 0, sizeof(visited));
					}
				}
			}
		}
	}

	cout << mx << endl;
}