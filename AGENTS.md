## 项目背景

C#上位机学习项目，用户0基础 + 自动化售后调试背景，目标2027年3月入职成都。

## 数据来源

计划基于2025-2026年成都/深圳公开JD调研 + C#上位机核心技术栈学习指南。

## 路线

详见 `.planning/task_plan.md`，五阶段：
0. 环境与工具链（1周）
1. C#进阶+多线程+文件IO（4周）
2. SQL Server+Dapper+EF Core（5周）
3. 工业通信（TCP/SerialPort/Modbus/S7/OPC UA）（8周）
4. WPF+MVVM+项目实战（8周）

## 技术栈

C#、WinForm、WPF、MVVM(CommunityToolkit)、SQL Server、MySQL(概念)、Dapper、EF Core、Socket、TCP/UDP、SerialPort、Modbus TCP/RTU、S7.Net、OPC UA(概念)、LiveCharts、HandyControl、Git、ClosedXML、NLog

## 红线

- 禁止 CheckForIllegalCrossThreadCalls = false
- 禁止简历写SQLite
- 禁止拖控件
- 计划基于真实数据，禁止臆测

## 学习节奏规则（核心）

### 自动推进
- 按天规划，每天一个明确知识点/任务
- 完成当天任务后自动引导到下一天
- 每过一天自然推进到下一天内容

### 不自动跳过
- 当天知识点没学完 → 不跳到下一天，直到掌握
- 小阶段结束时主动询问："这个知识点掌握了吗？项目做完了吗？"
- 用户说"还没好" → 不推进，等用户准备好了再继续

### 练习机制
- 每天学完有一个小练手（10-15分钟）
- 小阶段结束（每周）→ 实战项目/实操
- 大阶段结束 → 综合项目

### 项目来源优先级
1. GitHub 搜索相关开源项目（https://github.com/dashboard）
2. GitHub 找不到 → 我自己出项目题目

### 遇到问题
1. 先自己思考改代码
2. GitHub 搜索解决方案
3. Microsoft 官方文档
4. 再问我

## 规划文件

| 文件 | 用途 |
|------|------|
| .planning/task_plan.md | 五阶段+JD匹配+决策记录 |
| .planning/findings.md | 调研结论+缺口分析+环境记录 |
| .planning/progress.md | 会话日志+错误记录+五问检查 |

## 当前进度

阶段零·D2（5/30）：VS2022双环境配置

- [x] D1 Git安装+GitHub推送 ✅
- [ ] D2 VS2022配置 .NET Framework 4.7.2 + .NET 8
- [ ] D3 NuGet基础使用
- [ ] D4-5 WinForm动态控件复习 ✅ 已完成
- [ ] D6-7 周末项目：TODO列表小工具 push到GitHub
