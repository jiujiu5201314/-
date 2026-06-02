# 研究发现

> 数据来源：2025-2026年成都/深圳JD调研 + 四家AI（ChatGPT/Gemini/豆包v2）交叉验证

---

## 一、四家AI交叉验证结论（5/30）

### 四家共识（无需再争论）

| 共识 | 结论 |
|------|------|
| 通信 > 界面，WPF 是碗不是饭 | ✅ 采纳：WPF砍纯UI，只学到够用 |
| 西门子S7是PLC首选 | ✅ 采纳：只学S7.Net，不碰三菱/欧姆龙 |
| 原生SQL先于ORM | ✅ 采纳：Dapper是配菜 |
| WinForm + WPF 双修 | ✅ 采纳：WinForm先当通信调试壳 |
| 多线程是入场券 | ✅ 采纳：阶段一核心 |
| 别四种PLC一起学 | ✅ 采纳：只西门子 |
| 别疯狂学框架（Prism/IOC/DDD） | ✅ 采纳：Prism仅半天概念 |

### 四家分歧

| 争议点 | ChatGPT | Gemini | 豆包v2 | 裁决 |
|--------|:--:|:--:|:--:|------|
| SQLite vs SQL Server | 提了 | 狂推SQLite | 狂推SQLite | ❌ SQLite（JD数据不支持） |
| 买实体PLC | 没提 | 强烈要求 | 有条件建议 | ⏸ 模拟器先行，后期可买 |
| 数据库位置 | 放最后 | — | SQL放通信前 | ✅ SQL在通信前（读数据就要存） |
| WinForms | 跳过 | 强调 | 强调 | ✅ 保留WinForms |

### 新增采纳项

| 新增 | 来源 |
|------|------|
| SunnyUI/HZHControls 工业控件库 | 豆包v2 |
| Wireshark 抓包分析 | 豆包v2 + Gemini |
| 三种跨线程方案对比（Invoke/SyncContext/async-await） | 豆包v2 |
| 面试题库按类别重构 | 豆包v2 + ChatGPT |
| 安装包制作（Advanced Installer） | 豆包v2 |
| 批量写入 Bulk Insert | ChatGPT |
| 数据库表设计（DeviceLog/AlarmHistory/Recipe/ProductionRecord） | ChatGPT + 学习指南 |

---

## 二、JD 高频词统计（6条真实JD + 调研报告）

| 关键词 | 出现次数 | 覆盖 |
|--------|:--:|:--:|
| C# | 6/6 | ✅ |
| WPF | 5/6 | ✅ |
| SQL Server | 4/6 | ✅ |
| 串口通信 | 4/6 | ✅ |
| Modbus | 3/6 | ✅ |
| .NET | 5/6 | ✅ |
| PLC | 3/6 | ✅ |
| MVVM | 3/6 | ✅ |
| 多线程 | 3/6 | ✅ |
| Git | 2/6 | ✅ |
| SQLite | 0/6 | ❌ 不学 |

---

## 三、环境记录

| 工具 | 状态 | 用途 |
|------|:--:|------|
| VS2022 | ✅ | 开发 |
| Git | ✅ | 版本控制 |
| GitHub | ✅ | 代码托管 |
| Modbus Slave | ✅ | 模拟PLC |
| VSPD | ✅ COM1↔COM2 | 虚拟串口 |
| NetAssist | ⬜ | 网络调试 |
| Wireshark | ⬜ | 抓包分析 |
| SQL Server Express | ⬜ | 数据库 |
| SSMS | ⬜ | 数据库管理 |
| PLCSIM Advanced | ⬜ | 西门子PLC模拟 |
