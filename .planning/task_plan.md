# 上位机开发学习计划（基于成都/深圳真实JD调研）

> 数据来源：2025-2026年猎聘/智联/BOSS直聘/前程无忧公开岗位调研报告
> 目标：2027年3月入职成都上位机开发
> 用户背景：0基础编程 + 自动化售后调试经验
> 节奏：每晚2-2.5h，5+2模式

---

## 调研核心发现

| 发现 | 来源 | 影响 |
|------|------|------|
| C# + WPF + MVVM 是成都/深圳上位机标配 | 调研报告 | 阶段三重心 |
| WinForm + WPF **两者都要会** | 调研报告P2.1 | 不能放弃WinForm |
| SQL Server + MySQL 都要了解 | 学习指南 | 阶段二补MySQL概念 |
| Dapper/EF Core 至少会一个 | 学习指南 | 阶段二加入 |
| 西门子S7 是PLC通信首选 | 学习指南 | 阶段三加实操 |
| 推荐项目含报警/权限/日志/Excel | 学习指南 | 穿线项目加这些模块 |
| Git/SVN 版本控制必备 | 调研报告 | 全程使用 |

---

## 阶段零：环境与工具链（1周）
### 状态：in_progress

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| 1 | Git安装 + GitHub账号 + 项目初始化 | ✅ |
| 2 | VS2022配置（.NET Framework 4.7.2 + .NET 8双环境） | ⬜ |
| 3 | NuGet基础使用 | ⬜ |
| 4-5 | WinForm动态控件复习（Button/TextBox/ListBox/ComboBox/Label/Panel/GroupBox） | ✅ 已完成 |
| 6-7 | 周末：第一个WinForm小工具（TODO列表）push到GitHub | ⬜ |

---

## 阶段一：C# 进阶 + 多线程 + 文件IO（4周）
### 状态：in_progress

> 覆盖：委托/事件、Lambda、LINQ、Task/async-await、JSON/XML

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | 委托 delegate、Action、Func | ⬜ |
| W1D2 | 事件 event、EventHandler | ⬜ |
| W1D3 | Lambda表达式、匿名方法 | ⬜ |
| W1D4 | LINQ：Where/Select/OrderBy/GroupBy | ⬜ |
| W1D5 | LINQ实战：List筛选排序练习 | ⬜ |
| W1D6-7 | 周末：用LINQ做数据筛选小工具 | ⬜ |
| W2D1 | 文件读写：File.ReadAllText/WriteAllText | ⬜ |
| W2D2 | StreamReader/StreamWriter 逐行读写 | ⬜ |
| W2D3 | JSON序列化/反序列化（Newtonsoft.Json） | ⬜ |
| W2D4 | XML读写 | ⬜ |
| W2D5 | 配置面板保存/加载JSON | ⬜ |
| W2D6-7 | 周末：可保存配置的参数面板 | ⬜ |
| W3D1 | Thread 基础、前台/后台线程 | ⬜ |
| W3D2 | ThreadPool 线程池 | ⬜ |
| W3D3 | Task.Run()、Task.Factory | ⬜ |
| W3D4 | async/await 异步编程 | ⬜ |
| W3D5 | CancellationToken 取消任务 | ⬜ |
| W3D6-7 | 周末：多线程下载模拟器 | ⬜ |
| W4D1 | lock、Monitor 线程安全 | ⬜ |
| W4D2 | 生产者-消费者模型（BlockingCollection） | ⬜ |
| W4D3 | Invoke/BeginInvoke 跨线程更新UI | ⬜ |
| W4D4 | BackgroundWorker 组件 | ⬜ |
| W4D5 | 多线程综合练习 | ⬜ |
| W4D6-7 | 周末：后台线程更新UI不卡的小工具 | ⬜ |

---

## 阶段二：SQL Server + Dapper + EF Core（5周）
### 状态：pending

> 覆盖：SQL Server、MySQL、Dapper、EF Core、DataGridView

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | 安装SQL Server Express + SSMS | ⬜ |
| W1D2 | 数据库/表/行/列、主键、外键、索引 | ⬜ |
| W1D3 | 数据类型、IDENTITY、约束 | ⬜ |
| W1D4 | SSMS建库建表 | ⬜ |
| W1D5 | 手动插入20条模拟数据 | ⬜ |
| W1D6-7 | 周末：设计一个设备监控数据库（3张表） | ⬜ |
| W2D1 | INSERT INTO 增 | ⬜ |
| W2D2 | UPDATE/DELETE 改删 | ⬜ |
| W2D3 | SELECT + WHERE + ORDER BY 查 | ⬜ |
| W2D4 | JOIN 联表查询 | ⬜ |
| W2D5 | GROUP BY + 聚合函数 统计 | ⬜ |
| W2D6-7 | 周末：SQL综合练习 | ⬜ |
| W3D1 | SqlConnection + SqlCommand | ⬜ |
| W3D2 | 参数化查询（@参数）防注入 | ⬜ |
| W3D3 | SqlDataReader 逐行读 | ⬜ |
| W3D4 | DataTable + SqlDataAdapter | ⬜ |
| W3D5 | DataGridView绑定 + 增删改 | ⬜ |
| W3D6-7 | 周末：C#数据库CRUD小工具 | ⬜ |
| W4D1 | 事务 Transaction | ⬜ |
| W4D2 | using 自动释放连接 | ⬜ |
| W4D3 | 连接字符串存App.config | ⬜ |
| W4D4 | Windows认证 vs SQL认证 | ⬜ |
| W4D5 | 远程连接 + 防火墙1433 | ⬜ |
| W4D6-7 | 周末：连接管理 + MySQL概念认知 | ⬜ |
| W5D1 | NuGet：Dapper | ⬜ |
| W5D2 | Dapper Query/Execute | ⬜ |
| W5D3 | Dapper 参数化 + 事务 | ⬜ |
| W5D4 | EF Core 概念 + DbContext | ⬜ |
| W5D5 | EF Core Code First 建表 | ⬜ |
| W5D6-7 | 周末：Dapper + EF Core 对比练习 | ⬜ |

---

## 阶段三：工业通信（8周）
### 状态：pending

> 覆盖：TCP/UDP/Socket、SerialPort、Modbus TCP/RTU、S7 PLC、OPC UA概念

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | TCP/IP基础概念、三次握手 | ⬜ |
| W1D2 | Socket类、IPAddress、IPEndPoint | ⬜ |
| W1D3 | Connect + Send | ⬜ |
| W1D4 | Receive + 编码转换 | ⬜ |
| W1D5 | BitConverter Hex显示 | ⬜ |
| W1D6-7 | 周末：配合NetAssist，TCP双向收发工具 | ⬜ |
| W2D1 | UDP通信（UdpClient） | ⬜ |
| W2D2 | 粘包拆包问题 + 解决 | ⬜ |
| W2D3 | 心跳机制设计 | ⬜ |
| W2D4 | 断线自动重连 | ⬜ |
| W2D5 | try-catch + 异常分类 | ⬜ |
| W2D6-7 | 周末：TCP客户端（心跳+重连+不崩） | ⬜ |
| W3D1 | SerialPort类、GetPortNames() | ⬜ |
| W3D2 | 波特率/数据位/停止位/校验位 | ⬜ |
| W3D3 | DataReceived事件 | ⬜ |
| W3D4 | RS232 vs RS485 区别 | ⬜ |
| W3D5 | 配合VSPD串口收发 | ⬜ |
| W3D6-7 | 周末：串口调试工具 | ⬜ |
| W4D1 | Modbus协议理论（4种存储区） | ⬜ |
| W4D2 | 功能码01-06手动测试 | ⬜ |
| W4D3 | 功能码15-16手动测试 | ⬜ |
| W4D4 | 站号+寄存器地址 | ⬜ |
| W4D5 | CAS Modbus Scanner观察报文 | ⬜ |
| W4D6-7 | 周末：Modbus Slave搭10寄存器环境 | ⬜ |
| W5D1 | NuGet：FluentModbus | ⬜ |
| W5D2 | ModbusTcpClient 连接+读写 | ⬜ |
| W5D3 | ModbusRtuClient 串口连接 | ⬜ |
| W5D4 | 写寄存器/写线圈 | ⬜ |
| W5D5 | TCP vs RTU帧格式对比 | ⬜ |
| W5D6-7 | 周末：双模式Modbus读写工具 | ⬜ |
| W6D1 | 大小端概念 + 四种排列 | ⬜ |
| W6D2 | BitConverter 字节交换 | ⬜ |
| W6D3 | Float/Int32还原 | ⬜ |
| W6D4 | 通用字节序工具方法 | ⬜ |
| W6D5 | 多设备轮询设计 | ⬜ |
| W6D6-7 | 周末：字节序工具类 + 测试 | ⬜ |
| W7D1 | 西门子S7协议概念 | ⬜ |
| W7D2 | NuGet：S7.Net | ⬜ |
| W7D3 | S7.Net 读PLC数据 | ⬜ |
| W7D4 | S7.Net 写PLC数据 | ⬜ |
| W7D5 | S7 vs Modbus 对比 | ⬜ |
| W7D6-7 | 周末：PLC模拟器+S7.Net读写 | ⬜ |
| W8D1 | OPC UA 概念（什么是OPC） | ⬜ |
| W8D2 | OPC UA vs Modbus | ⬜ |
| W8D3 | EtherCAT概念（仅了解） | ⬜ |
| W8D4 | 运动控制概念（仅了解） | ⬜ |
| W8D5 | 机器视觉概念（Halcon/VisionPro） | ⬜ |
| W8D6-7 | 周末：工业通信全景复习 | ⬜ |

---

## 阶段四：WPF + MVVM + 项目实战（8周）
### 状态：pending

> 覆盖：XAML、Binding、MVVM、CommunityToolkit.Mvvm、LiveCharts、HandyControl

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| W1D1 | WPF vs WinForms 思维转变 | ⬜ |
| W1D2 | XAML语法 + Grid布局 | ⬜ |
| W1D3 | StackPanel/DockPanel/WrapPanel | ⬜ |
| W1D4 | Margin/Padding/对齐 | ⬜ |
| W1D5 | 资源字典 ResourceDictionary | ⬜ |
| W1D6-7 | 周末：自适应工业监控主窗体 | ⬜ |
| W2D1 | TextBlock/TextBox/Button/ComboBox WPF版 | ⬜ |
| W2D2 | DataGrid、ListView | ⬜ |
| W2D3 | Style样式 + Trigger触发器 | ⬜ |
| W2D4 | ControlTemplate 控件模板 | ⬜ |
| W2D5 | 自定义控件基础 | ⬜ |
| W2D6-7 | 周末：WPF重写设备参数配置面板 | ⬜ |
| W3D1 | {Binding} 基础语法 | ⬜ |
| W3D2 | DataContext 数据上下文 | ⬜ |
| W3D3 | INotifyPropertyChanged | ⬜ |
| W3D4 | IValueConverter 值转换 | ⬜ |
| W3D5 | 数据验证 IDataErrorInfo | ⬜ |
| W3D6-7 | 周末：零事件代码的绑定表单 | ⬜ |
| W4D1 | MVVM概念：M-V-VM三层 | ⬜ |
| W4D2 | ICommand + RelayCommand | ⬜ |
| W4D3 | CommunityToolkit.Mvvm入门 | ⬜ |
| W4D4 | ObservableObject + RelayCommand | ⬜ |
| W4D5 | 消息机制 Messenger | ⬜ |
| W4D6-7 | 周末：串口助手MVVM重构 | ⬜ |
| W5D1 | HandyControl引入 | ⬜ |
| W5D2 | ToggleSwitch/Loading/Growl | ⬜ |
| W5D3 | 深色/浅色主题 | ⬜ |
| W5D4 | 现代化表单美化 | ⬜ |
| W5D5 | 自定义窗口样式 | ⬜ |
| W5D6-7 | 周末：全面美化 | ⬜ |
| W6D1 | LiveCharts.Wpf 引入 | ⬜ |
| W6D2 | CartesianChart + LineSeries | ⬜ |
| W6D3 | 多曲线 + X轴时间格式 | ⬜ |
| W6D4 | 滚动刷新 + 缩放 | ⬜ |
| W6D5 | 实时曲线 + 历史回放 | ⬜ |
| W6D6-7 | 周末：模拟数据实时看板 | ⬜ |
| W7D1 | Frame + Page 导航 | ⬜ |
| W7D2 | 左侧菜单 + 页面切换 | ⬜ |
| W7D3 | 页面动画 | ⬜ |
| W7D4 | 用户控件 UserControl | ⬜ |
| W7D5 | Prism 框架概念（仅了解） | ⬜ |
| W7D6-7 | 周末：多页面导航系统 | ⬜ |
| W8 | 简历王牌项目开发（见下方） | ⬜ |

---

## 简历王牌项目：工业设备监控系统

> 对标JD要求的完整项目，涵盖调研报告中所有高频技术栈

### 功能模块
| 模块 | 技术点 | 对应JD |
|------|--------|--------|
| 设备通信 | Modbus TCP/RTU + S7 PLC | 工业通信 |
| 实时监控 | WPF + MVVM + LiveCharts实时曲线 | WPF开发经验 |
| 数据管理 | SQL Server + Dapper + 历史查询 | 数据库开发 |
| 报警管理 | 阈值判断 + 实时弹窗 + 报警日志 | 报警管理 |
| 用户权限 | 登录 + 角色权限（管理员/操作员） | 用户权限 |
| 日志系统 | NLog 文件日志 + 数据库日志 | 日志系统 |
| 配置管理 | JSON配置文件 + 界面配置 | 配置管理 |
| Excel导出 | ClosedXML 导出历史数据 | Excel导出 |
| 异常处理 | 断线重连 + 异常捕获 + 错误日志 | 通信稳定性 |

---

## 打磨阶段（2月·4周）
### 状态：pending

| 天 | 内容 | 状态 |
|:--:|------|:--:|
| 1-3 | GitHub：README + 截图 + 架构图 + 演示视频 | ⬜ |
| 4-5 | 简历撰写（项目经历+行业背景+对标JD） | ⬜ |
| 6 | 原型图工具认知（Axure/墨刀，半天） | ⬜ |
| 7-8 | 面试题库（委托/LINQ/多线程/Modbus/绑定/MVVM/EF Core） | ⬜ |
| 9-10 | 模拟面试（自我介绍+项目介绍，录音反复练） | ⬜ |

---

## 各阶段技术栈对照JD

| JD高频要求 | 阶段 | 掌握程度 |
|------------|:--:|:--:|
| C# + .NET | 全程 | 熟练 |
| WinForm + WPF | 全程 | 双框架 |
| 委托/事件/Lambda/LINQ | 一 | 熟练 |
| 多线程/async-await | 一 | 熟练 |
| SQL Server + MySQL | 二 | SQL Server熟练，MySQL了解 |
| Dapper + EF Core | 二 | Dapper熟练，EF Core会用 |
| Socket/TCP/UDP | 三 | 熟练 |
| SerialPort/RS232/RS485 | 三 | 熟练 |
| Modbus TCP/RTU | 三 | 熟练 |
| S7 PLC通信 | 三 | 会用S7.Net |
| OPC UA | 三 | 概念+了解 |
| MVVM/CommunityToolkit | 四 | 熟练 |
| WPF数据绑定/样式/模板 | 四 | 熟练 |
| LiveCharts实时曲线 | 四 | 会用 |
| Git版本控制 | 零 | 全程使用 |
| Excel导出 | 项目 | 会用ClosedXML |

---

## 禁止事项
- 禁止 `CheckForIllegalCrossThreadCalls = false`
- 禁止简历写 SQLite
- 禁止拖控件

## 决策记录
| 日期 | 决策 | 数据依据 |
|------|------|------|
| 5/30 | 加入Dapper+EF Core | 学习指南明确列为数据库核心技术栈 |
| 5/30 | 加入S7.Net实操 | 学习指南：推荐优先学习西门子S7 |
| 5/30 | WinForm+WPF双修 | 调研报告：几乎所有岗位要求两者都会 |
| 5/30 | 加入CommunityToolkit.Mvvm | 学习指南列为核心MVVM框架 |
| 5/30 | 项目加报警/权限/日志/Excel | 学习指南推荐项目的完整功能 |
| 5/30 | 加入MySQL概念 | 调研报告多岗位同时要求SQL Server和MySQL |
| 5/30 | 加入Git全程使用 | 调研报告：版本控制工具操作能力是标配 |
