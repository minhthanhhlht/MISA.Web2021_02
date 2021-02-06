<template>
  <div class="content">
    <div class="content-body">
      <div class="header-content">
        <div class="title">Danh sách nhân viên</div>
        <div class="content-feature">
          <button
            id="btnAdd"
            class="m-btn m-btn-default"
            v-on:click="btnAddOnClick"
          >
            <div class="m-btn-icon icon-add"></div>
            <div class="btn-text">Thêm nhân viên</div>
          </button>
          <Details @closePopup="closePopup" :isHide="isHideParent" />
        </div>
      </div>
      <div class="filter-bar">
        <div class="filter-left">
          <input
            id="txtSearchEmployee"
            class="icon-search input-search"
            type="text"
            placeholder="Tìm kiếm theo Mã, Tên hoặc Số điện thoại"
          />
          <select
            id="cbxDepartment"
            fieldName="CustomerGroupName"
            fieldValue="CustomerGroupId"
            api="/api/customergroups"
            class="m-control"
          >
            <option value="19165ed7-212e-21c4-0428-030d4265475f">
              Tất cả phòng ban
            </option>
            <option value="19165ed7-212e-21c4-0428-030d4265475f">
              Văn phòng Tổng công ty
            </option>
            <option value="7a0b757e-41eb-4df6-c6f8-494a84b910f4">
              Phòng đào tạo công nghệ
            </option>
            <option value="3631011e-4559-4ad8-b0ad-cb989f2177da">
              Phòng Nhân sự
            </option>
          </select>
          <select
            id="cbxPosition"
            fieldName="CustomerGroupName"
            fieldValue="CustomerGroupId"
            api="/api/customergroups"
            class="m-control"
          >
            <option value="19165ed7-212e-21c4-0428-030d4265475f">
              Tất cả vị trí
            </option>
            <option value="19165ed7-212e-21c4-0428-030d4265475f"
              >Giám đốc</option
            >
            <option value="7a0b757e-41eb-4df6-c6f8-494a84b910f4">
              Trưởng phòng
            </option>
            <option value="3631011e-4559-4ad8-b0ad-cb989f2177da">
              Nhân viên
            </option>
          </select>
        </div>
        <div class="filter-right">
          <button
            id="btnRefresh"
            class="m-second-button m-btn-refresh"
          ></button>
        </div>
      </div>
    </div>

    <div
      class="grid grid-employee el-table el-table--fit el-table--scrollable-y el-table--enable-row-hover el-table--enable-row-transition"
    >
      <table
        id="tbListData"
        cellspacing="0"
        cellpadding="0"
        border="0"
        class="el-table__body"
        style="min-width: 100%"
      >
        <thead class="has-gutter">
          <tr class="el-table__row">
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_114 is-leaf"
              fieldName="EmployeeCode"
            >
              <div class="cell">Mã nhân viên</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_115 is-leaf"
              fieldName="FullName"
            >
              <div class="cell">Họ và tên</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="GenderName"
            >
              <div class="cell">Giới tính</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="DateOfBirth"
              formatType="ddmmyyyy"
              style="text-align: center"
            >
              <div class="cell">Ngày sinh</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="PhoneNumber"
            >
              <div class="cell">Điện thoại</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="Email"
            >
              <div class="cell">Email</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="PositionName"
            >
              <div class="cell">Chức vụ</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="DepartmentName"
            >
              <div class="cell">Phòng ban</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="Salary"
              formatType="Money"
            >
              <div class="cell" style="text-align: right">Mức lương cơ bản</div>
            </th>
            <th
              colspan="1"
              rowspan="1"
              class="el-table_30_column_116 is-leaf"
              fieldName="WorkStatusName"
            >
              <div class="cell">Tình trạng công việc</div>
            </th>
            <th class="gutter" style="width: 6px"></th>
          </tr>
        </thead>
        <tbody>
          <tr
            class="el-table__row"
            v-for="employee in employees"
            :key="employee.EmployeeId"
            @dblclick="rowOnClick(employee)"
          >
            <td>
              <div class="cell">{{ employee.EmployeeCode }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.FullName }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.GenderName }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.DateOfBirth }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.PhoneNumber }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.Email }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.PositionName }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.DepartmentName }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.Salary }}</div>
            </td>
            <td>
              <div class="cell">{{ employee.WorkStatusName }}</div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
    <div class="paging-bar">
      <div class="paging-record-info">Hiển thị <b>1-10/1000</b> nhân viên</div>
      <div class="paging-option">
        <div class="btn-select-page m-btn-firstpage"></div>
        <div class="btn-select-page m-btn-prev-page"></div>
        <div class="m-btn-list-page">
          <button class="btn-pagenumber btn-pagenumber-selected">1</button>
          <button class="btn-pagenumber">2</button>
          <button class="btn-pagenumber">3</button>
          <button class="btn-pagenumber">4</button>
        </div>
        <div class="btn-select-page m-btn-next-page"></div>
        <div class="btn-select-page m-btn-lastpage"></div>
      </div>
      <div class="paging-record-option"><b>10</b> nhân viên/trang</div>
    </div>
  </div>
</template>

<script>
import Details from "./EmployeeDialogDetail";
export default {
  name: "Employee",
  components: {
    Details,
  },
  methods: {
    btnAddOnClick() {
      this.isHideParent = true;
    },
  },
};
</script>

<style></style>
