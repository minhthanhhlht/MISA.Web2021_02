<template>
    <div>
         <!--dialog employee-->
    <div class="employee-dialog dialog-detail" title="Thông tin nhân viên">
        <div class="dialog-content">
            <div class="dialog-body">
                <div class="m-row m-flex">
                    <div class="m-col el-avatar-employee m-flex-1">
                        <div class="el-avatar"></div>
                        <div class="el-avatar-note text-align-center">
                            (Vui lòng chọn ảnh có định dạng <br><b>.jpg, .jpeg, .png, .gif. </b>)
                        </div>
                    </div>
                    <div class="m-col el-left  m-flex-4">
                        <div class="group-label-info">
                            A. Thông tin chung:
                        </div>
                        <hr class="hr-group-label" />
                        <div class="m-row mg-top-0 m-flex">
                            <div class="m-col m-flex-1">
                                <div class="m-label">Mã nhân viên (<span class="label-required">*</span>)</div>
                                <div class="m-control"><input id="txtEmployeeCode" fieldName="EmployeeCode" required class="input-required givenclassS" type="text" /></div>
                            </div>
                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-label">Họ và tên (<span class="label-required">*</span>)</div>
                                <div class="m-control">
                                    <input id="txtFullName" fieldName="FullName" class="input-required" type="text" required />
                                </div>
                            </div>
                        </div>
                        <div class="m-row m-flex">
                            <div class="m-flex-1">
                                <div class="m-date-picker">
                                    <div class="m-label">Ngày sinh</div>
                                    <div class="m-control">
                                        <div class="dateInput">
                                            <input id="dtDateOfBirth" date-picker="" format="dd/mm/yyyy" fieldName="DateOfBirth" type="date" autocomplete="off" class="hasDatepicker" />

                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-label">Giới tính</div>
                                <div class="m-select" id="cbnGender" fieldName="Gender">
                                    <select id="cbxGender" fieldName="Gender" class="m-input">
                                        <option value="0">Nam</option>
                                        <option value="1">Nữ</option>
                                        <option value="2">Khác</option>
                                    </select>
                                </div>



                            </div>
                        </div>
                        <div class="m-row m-flex">
                            <div class="m-flex-1">
                                <div class="m-label" title="Số chứng minh thư nhân dân hoặc căn cước công dân">Số CMTND/ Căn cước (<span class="label-required">*</span>)</div>
                                <div class="m-control"><input id="txtIdentityNumber" fieldName="IdentityNumber" type="text" required /></div>
                            </div>
                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-date-picker">
                                    <div class="m-label">Ngày cấp</div>
                                    <div class="m-control">
                                        <div class="dateInput">
                                            <input id="dtIndentityDate" date-picker="" format="dd/mm/yyyy" fieldName="IndentityDate" type="date" autocomplete="off" class="hasDatepicker" />

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="m-row m-flex">
                            <div class="m-flex-1">
                                <div class="m-label">Nơi cấp</div>
                                <div class="m-control">
                                    <input id="txtIdentityPlace" fieldName="IdentityPlace" class="input-required" type="text" />
                                </div>
                            </div>
                            <div class="m-flex-1">
                            </div>
                        </div>
                        <div class="m-row m-flex">
                            <div class="m-col m-flex-1">
                                <div class="m-label">Email (<span class="label-required">*</span>)</div>
                                <div class="m-control">
                                    <input id="txtEmail" fieldName="Email" type="email" placeholder="example@domain.com" required />
                                </div>
                            </div>
                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-label">Số điện thoại (<span class="label-required">*</span>)</div>
                                <div class="m-control">
                                    <input id="txtPhoneNumber" fieldName="PhoneNumber" class="input-required" type="text" required />
                                </div>
                            </div>

                        </div>
                        <div class="group-label-info" style="margin-top:30px">
                            B. Thông tin công việc:
                        </div>
                        <hr class="hr-group-label" />
                        <div class="m-row m-flex">
                            <div class="m-flex-1">
                                <div class="m-label">Vị trí</div>
                                <div class="m-select" id="cbxPosition" fieldName="Position">
                                    <select id="cbxPositionId" fieldName="PositionId" class="m-input">
                                        <option value="447816de-6069-15bf-de3d-c9e9e9038fe2">Giám Đốc</option>
                                        <option value="39446ba3-3071-7af6-a5a9-deaf32c96293">Trưởng Phòng</option>
                                        <option value="3541ff76-58f0-6d1a-e836-63d5d5eff719">Nhân Viên</option>
                                    </select>
                                </div>

                            </div>
                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-label">Phòng ban</div>
                                <div class="m-select" id="cbnDepartment" fieldName="Department">
                                    <select id="cbxDepartmentId" fieldName="DepartmentId" class="m-input">
                                        <option value="64a59a25-2488-54b0-f6b4-c8af08a50cbf">Phòng Markerting</option>
                                        <option value="674934cc-42cf-20cf-1d4a-aea48a10ed18">Phòng Tổng Hợp</option>
                                        <option value="34bd2cef-5026-567c-3b71-153b37881afe">Phòng Nhân Sự</option>
                                        <option value="43a6bdf5-1b6b-451b-3695-2c566fa88632">Phòng Công Nghệ</option>
                                    </select>
                                </div>

                            </div>
                        </div>
                        <div class="m-row m-flex">
                            <div class="m-flex-1">
                                <div class="m-label">Mã số thuế cá nhân</div>
                                <div class="m-control">
                                    <input id="txtPersonalTaxCode" fieldName="PersonalTaxCode" type="text" />
                                </div>
                            </div>
                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-label">Mức lương cơ bản</div>
                                <div class="m-control">
                                    <input id="txtMoney" data-type="currency" fieldName="Money" type="text" style="text-align:right; padding-right: 56px" /><span class="currency-for-input">(VNĐ)</span>
                                </div>
                            </div>
                        </div>
                        <div class="m-row m-flex">
                            <div class="m-flex-1">
                                <div class="m-date-picker">
                                    <div class="m-label">Ngày gia nhập</div>
                                    <div class="m-control">
                                        <div class="dateInput">
                                            <input id="dtJoinDate" date-picker="" format="dd/mm/yyyy" fieldName="JoinDate" type="date" autocomplete="off" class="hasDatepicker" />

                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="m-flex-1 mg-left-10px">
                                <div class="m-label">Tình trạng công việc</div>
                                <div class="m-select" id="cboWorkStatus" fieldName="CustomerGroupName">
                                    <select id="cbxWorkStatusName" fieldName="WorkStatusName" class="m-input">
                                        <option value="Đang Làm Việc">Đang Làm Việc</option>
                                        <option value="Đã Nghỉ">Đã Nghỉ</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="dialog-footer">
            <button id="btnCancel" class="m-btn m-btn-default m-btn-cancel">Hủy</button>
            <button id="btnEdit" class="m-btn m-btn-default m-btn-edit">
                <div class="m-btn-edit1"></div>
                <span class="btn-text">Sửa</span>
            </button>
            <button id="btnSave" class="m-btn m-btn-default m-btn-save">
                <div class="m-btn-save1"></div>
                <span class="btn-text">Lưu</span>
            </button>
        </div>
    </div>
    </div>
</template>

<script>
export default {
    name: 'EmployeeDialogDetail',


};
</script>

<style lang="scss" scoped>
.isHide {
  display: none;
}
.employee-dialog {
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