<template>
  <div>
    <!-- <button id="btnAdd" class="m-btn m-btn-default" v-on:click="btnAddOnClick">
      <div class="m-btn-icon icon-add"></div>
      <div class="btn-text">Thêm nhân viên</div>
    </button> -->
    <div
      class="m-dialog dialog-detail"
      title="Thông tin nhân viên"
      :class="{ isHide: isHide }"
    >
      <div class="dialog-modal"></div>
      <div class="dialog-content">
        <div class="dialog-header">
          <div class="dialog-header-title">THÔNG TIN NHÂN VIÊN</div>
          <div class="dialog-header-close">
            <button v-on:click="btnCancelOnClick">x</button>
          </div>
        </div>
        <div class="dialog-body">
          <div class="m-row m-flex">
            <div class="m-col el-avatar-employee m-flex-1">
              <div class="el-avatar"></div>
              <div class="el-avatar-note text-align-center">
                (Vui lòng chọn ảnh có định dạng <br /><b
                  >.jpg, .jpeg, .png, .gif. </b
                >)
              </div>
            </div>
            <div class="m-col el-left m-flex-4">
              <div class="group-label-info">A. Thông tin chung:</div>
              <hr class="hr-group-label" />
              <div class="m-row mg-top-0 m-flex">
                <div class="m-col m-flex-1">
                  <div class="m-label">
                    Mã nhân viên (<span class="label-required">*</span>)
                  </div>
                  <div class="m-control">
                    <input
                      id="txtEmployeeCode"
                      fieldName="EmployeeCode"
                      required
                      class="input-required"
                      type="text"
                      v-model="EmpData.EmployeeCode"
                    />
                  </div>
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">
                    Họ và tên (<span class="label-required">*</span>)
                  </div>
                  <div class="m-control">
                    <input
                      id="txtFullName"
                      fieldName="FullName"
                      class="input-required"
                      type="text"
                      v-model="EmpData.FullName"
                      required
                    />
                  </div>
                </div>
              </div>
              <div class="m-row m-flex">
                <div class="m-flex-1">
                  <div class="m-label">Ngày sinh</div>
                  <input
                    class="m-combobox-input"
                    type="date"
                    autocomplete="off"
                    v-model="EmpData.DateOfBirth"
                  />
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">Giới tính</div>
                  <select id="cbxGender" class="m-control" v-model="EmpData.Gender">
                    <option class="gender" value="1">Nam</option>
                    <option class="gender" value="0">Nữ</option>
                    <option class="gender" value="2">Khác</option>
                  </select>
                </div>
              </div>
              <div class="m-row m-flex">
                <div class="m-flex-1">
                  <div
                    class="m-label"
                    title="Số chứng minh thư nhân dân hoặc căn cước công dân"
                  >
                    Số CMTND/ Căn cước (<span class="label-required">*</span>)
                  </div>
                  <div class="m-control">
                    <input
                      id="txtIdentityNumber"
                      fieldName="text"
                      type="text"
                      v-model="EmpData.IdentifyNumber"
                      required
                    />
                  </div>
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">Ngày cấp</div>
                  <input
                    class="m-combobox-input"
                    type="date"
                    autocomplete="off"
                    v-model="EmpData.DateOfIn"
                  />
                </div>
              </div>
              <div class="m-row m-flex">
                <div class="m-flex-1">
                  <div class="m-label">Nơi cấp</div>
                  <div class="m-control">
                    <input
                      id="txtIdentityPlace"
                      fieldName="PhoneNumber"
                      class="input-required"
                      type="text"
                      v-model="EmpData.PlaceOfIN"
                    />
                  </div>
                </div>
                <div class="m-flex-1"></div>
              </div>
              <div class="m-row m-flex">
                <div class="m-col m-flex-1">
                  <div class="m-label">
                    Email (<span class="label-required">*</span>)
                  </div>
                  <div class="m-control">
                    <input
                      id="txtEmail"
                      fieldName="Email"
                      type="email"
                      required
                      placeholder="example@domain.com"
                      v-model="EmpData.Email"
                    />
                  </div>
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">
                    Số điện thoại (<span class="label-required">*</span>)
                  </div>
                  <div class="m-control">
                    <input
                      id="txtPhoneNumber"
                      fieldName="FullName"
                      class="input-required"
                      type="text"
                      v-model="EmpData.PhoneNumber"
                      required
                    />
                  </div>
                </div>
              </div>
              <div class="group-label-info" style="margin-top: 30px">
                B. Thông tin công việc:
              </div>
              <hr class="hr-group-label" />
              <div class="m-row m-flex">
                <div class="m-flex-1">
                  <div class="m-label">Vị trí</div>
                  <select
                    id="cbxPosition"
                    fieldName="CustomerGroupName"
                    fieldValue="CustomerGroupId"
                    api="/api/customergroups"
                    class="m-control"
                    v-model="EmpData.PositionId"
                  >
                    <option value="2b031b59-5276-589c-9d75-2a7ae1c799c4">Chọn vị trí</option>
                    <option value="6118a7ff-742b-25db-a9c1-8e252c39bb73">Giám đốc</option>
                    <option value="26021185-77af-263c-842a-acc8fc2f00af">Trưởng phòng</option>
                    <option value="2b031b59-5276-589c-9d75-2a7ae1c799c8">Nhân viên</option>
                  </select>
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">Phòng ban</div>
                  <select
                    id="cbnDepartment"
                    fieldName="CustomerGroupName"
                    fieldValue="CustomerGroupId"
                    api="/api/customergroups"
                    class="m-control"
                    v-model="EmpData.DepartmentId"
                  >
                    <option value="25c6c36e-1668-7d10-6e09-bf1378b8dc98">Chọn Phòng ban</option>
                    <option value="148ed882-32b8-218e-9c20-39c2f00615e8">Phòng nhân sự</option>
                    <option value="25c6c36e-1668-7d10-6e09-bf1378b8dc91">Phòng quản lý</option>
                    <option value="3700cc49-55b5-69ea-4929-a2925c0f334d">Phòng đào tạo</option>
                  </select>
                </div>
              </div>
              <div class="m-row m-flex">
                <div class="m-flex-1">
                  <div class="m-label">Mã số thuế cá nhân</div>
                  <div class="m-control">
                    <input id="txtAddress" fieldName="Address" type="text" v-model="EmpData.TaxCode"/>
                  </div>
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">Mức lương cơ bản</div>
                  <div class="m-control">
                    <input
                      id="txtSalary"
                      fieldName="Salary"
                      type="text"
                      style="text-align: right; padding-right: 56px"
                      v-model="EmpData.Salary"
                    /><span class="currency-for-input">(VNĐ)</span>
                  </div>
                </div>
              </div>
              <div class="m-row m-flex">
                <div class="m-flex-1">
                  <div class="m-label">Ngày gia nhập</div>
                  <input
                    class="m-combobox-input"
                    type="date"
                    autocomplete="off"
                    v-model="EmpData.DateOfBeginWork"
                  />
                </div>
                <div class="m-flex-1 mg-left-10px">
                  <div class="m-label">Tình trạng công việc</div>
                  <select
                    id="cboWorkStatus"
                    fieldName="CustomerGroupName"
                    fieldValue="CustomerGroupId"
                    api="/api/customergroups"
                    class="m-control"
                    v-model="EmpData.Status"
                  >
                    <option value="2">Đang làm việc</option>
                    <option value="0">Đã nghỉ việc</option>
                    <option value="1">Đang thử việc</option>
                    <option value="3">Đã nghỉ hưu</option>
                  </select>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div class="dialog-footer">
          <button id="btnCancel" class="m-btn m-btn-default m-btn-cancel" v-on:click="btnCancelOnClick">
            Hủy
          </button>
          <button id="btnSave" class="m-btn m-btn-default">
            <i class="far fa-save"></i><span class="btn-text" v-on:click="saveEmployee">Lưu</span>
          </button>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import * as axios from "axios";

export default {
  props: ['isHide'],
  methods: {
    btnAddOnClick() {
      //this.isHide = false;
    },
    btnCancelOnClick() {
      this.$emit('closePopup', true)
      //this.isHide = true;
    },
    rowOnClick(employee) {
      alert(employee.FullName);
    },
    async saveEmployee() {
      console.log('OK');
      await axios.post("https://localhost:44337/api/Employees", this.EmpData)
      .then(response => {
          console.log(response.data['Data']);
          alert("Thêm mới nhân viên " + response.data['Message']);
          this.EmpData['EmployeeCode'] = '';
          this.EmpData['FullName'] = '';
          this.EmpData['DateOfBirth'] = '';
          this.EmpData['Gender'] = '';
          this.EmpData['IdentifyNumber'] = '';
          this.EmpData['DateOfIN'] = '';
          this.EmpData['PlaceOfIN'] = '';
          this.EmpData['Email'] = '';
          this.EmpData['PhoneNumber'] = '';
          this.EmpData['PositionId'] = '2b031b59-5276-589c-9d75-2a7ae1c799c4';
          this.EmpData['DepartmentId'] = '25c6c36e-1668-7d10-6e09-bf1378b8dc98',
          this.EmpData['DateOfBeginWork'] = '';
          this.EmpData['Salary'] = '';
          this.EmpData['Email'] = '';
          this.EmpData['Status'] = '';

          //this.$emit('addSuccess');
      })
      .catch(error => {
          alert(error.response.data['Message']);
      })
    }
  },
  data() {
    return {
      dialog: false,
      //isHide: true,
      display: "none",

      EmpData: {
        'EmployeeCode': '',
        'FullName': '',
        'DateOfBirth': '',
        'Gender' : '',
        'IdentifyNumber': '',
        'DateOfIN': '',
        'PlaceOfIN': '',
        'Email' : '',
        'PhoneNumber': '',
        'PositionId': '2b031b59-5276-589c-9d75-2a7ae1c799c4',
        'DepartmentId': '25c6c36e-1668-7d10-6e09-bf1378b8dc98',
        'TaxCode' : '',
        'Salary': '',
        'DateOfBeginWork': '',
        'Status': '',
      },
    };
  },
};
</script>
<style scoped>
.isHide {
  display: none;
}
.m-dialog {
  z-index: 999;
}

.dialog-header {
  position: relative;
  height: 40px;
  line-height: 60px;
  padding-left: 16px;
  display: flex;
  font-size: 24px;
}

.dialog-header-close {
  position: absolute;
  right: 16px;
  width: 24px;
  height: 24px;
  border-radius: 50%;
  cursor: pointer;
  top: 10px;
  align-items: center;
  border: none;
  background-color: transparent;
  font-size: 24px;
  line-height: 24px;
}
.dialog-modal {
  position: fixed;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background-color: black;
  opacity: 0.4;
}

.dialog-content {
  position: fixed;
  border-radius: 5px;
  width: 750px;
  background-color: #fff;
  left: calc(50% - 325px);
  top: calc(50% - 450px);
}
.dialog-body {
  padding: 0 16px 16px 16px;
}
.dialog-footer {
  display: flex;
  width: 100%;
  height: 60px;
  background-color: #e9ebee;
  border-radius: 0 0 5px 5px;
  align-items: center;
  justify-content: flex-end;
  padding: 12px 24px;
  box-sizing: border-box;
}
.el-avatar-employee {
  padding-top: 16px;
  padding-right: 16px;
}
.el-avatar-note {
  font-size: 12px;
}
.el-avatar-employee .el-avatar {
  border: 1px solid #ccc;
  width: 160px;
  height: 160px;
  margin: 0 auto;
  border-radius: 50%;
  cursor: pointer;
  background-image: url(/content/img/default-avatar.jpg);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
}
.currency-for-input {
  position: absolute;
  right: 40px;
  line-height: 40px;
  font-style: italic;
}
</style>