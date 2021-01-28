<template>
  <transition name="component-fade" mode="out-in">
    <div class="h-confirm h-container-around-center" v-show="visible">
      <div class="h-icon-confirm">
        <i class="fas fa-check"></i>
      </div>

      <div class="h-confirm-content">
        <slot></slot>
      </div>
    </div>
  </transition>
</template>

<script>
export default {
  data() {
    return {
      visible: false,
    };
  },

  methods: {
    hide() {
      this.visible = false;
    },
    show: async function () {
      this.visible = true;
      setTimeout(
        function () {
          this.visible =false;
        }.bind(this), 3000
      );
    },
  },
};
</script>

<style src="./modal.scss" lang="scss" />
<style scoped>
.h-confirm {
  position: fixed;
  right: 10px;
  top: 10px;
  width: 200px;
  height: fit-content;
  min-height: 50px;
  background-color: seagreen;
  color: white;
  z-index: 10000;
  border-radius: 4px;
  box-shadow: inset 0 1px 1px rgb(0 0 0 / 8%), 0 0 8px rgb(102 175 233 / 60%);
}
.h-icon-confirm {
  padding-left: 15px;
  padding-right: 10px;
}

.h-confirm-content {
  padding: 10px;
}

.component-fade-enter-active {
  animation: bounce-in 0.3s ;
}
.component-fade-leave-active {
  animation: bounce-out 2s ;
}
@keyframes bounce-in {
  0% {
    transform: translatex(-55px);
    opacity: 0;
  }

  100% {
    transform: translatex(0px);
    opacity: 1;
  }
}
@keyframes bounce-out {
  100% {
    opacity: 0;
    transform: translatex(0px);
  }
}
</style>