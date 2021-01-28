<template>
<transition name="component-fade" mode="out-in">
<div class="h-dialog" v-show="visible">
    <div class="h-dialog-background"></div>
    <div class="h-dialog-content content-delete">     
     
    <div class="warning-text">
        <h2 style="color: red;">Cảnh báo có {{listId.length}} nhân viên được chọn !</h2>
        <p style="font-size: 16px;padding: 16px;">Bạn có chắc muốn Xóa thông tin nhân viên này không ?</p>
      </div>
      <div class="warning-btn">
        <button class="h-btn h-cancel-btn" id="btnCancel2" @click="hide()">Hủy</button>
        <button class="h-btn h-save-btn" id="btnOk" @click="Confirm()">Có</button>
      </div>
    </div>
    
  </div>
</transition>
  
</template>

<script>
import * as axios from "axios";

export default {
  props: {
      listId: Array
  }, 
  data() {
    return {
      visible: false,     
    };
  },
 
  methods: {
    hide() {
     
      this.visible = false;
    },
    show() {       
      this.visible = true;     
    },

    async Confirm(){      
      var confirm =[];
      console.log(this.employee);
      this.listId.forEach(async function(item){     
         console.log("id: "+item);  
          await axios.delete('http://api.manhnv.net/api/employees', item)
            .then(function (res) {
              console.log("success: "+res);
             confirm.push({id: item, state: true});
            })
            .catch(function (err) {
               console.log("false: " +err);    
               confirm.push({id: item, state: false});       
            });

            this.$emit("deleted", confirm);        


      });
      
      
    }
  },
};
</script>

<style src="../modal.scss" lang="scss" />
<style scoped>



.component-fade-enter-active {
  transition: all .3s ease-in-out;
}
.component-fade-leave-active {
  transition: all .3s ease-in-out;
}
.component-fade-enter, .component-fade-leave-to
/* Trước 2.1.8 thì dùng .slide-fade-leave-active */ {
  transform: translatey(-15px);
  opacity: 0;
}
</style>